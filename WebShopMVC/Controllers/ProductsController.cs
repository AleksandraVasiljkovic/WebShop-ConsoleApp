using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Amazon.SimpleDB.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using WebShop.Bsn;
using WebShop.Model;
using Microsoft.Extensions.Configuration;
namespace WebShopMVC.Controllers
{
    public class ProductsController : Controller
    {
        private IConfiguration configuration;
        private UserModel userSession;
        public ProductsController(IConfiguration iConfig)
        {
            configuration = iConfig;
            
        }
        public async Task<IActionResult> Index()
        {

            ProductModel productsModel = new ProductModel();
            productsModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetProducts")));
            userSession = SessionHelper.GetObjectFromJson<UserModel>(HttpContext.Session, "userObject");
            productsModel.IsAdmin = userSession != null ? userSession.IsAdmin : false;
            productsModel.listCategory = JsonConvert.DeserializeObject<List<CategoriesModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetCategories")));
            return View(productsModel);
        }
        
        public async Task<IActionResult> Edit(int productId)
        {
            ProductModel productModel = JsonConvert.DeserializeObject<ProductModel>(await MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/EditProduct/" , productId)));
            return View(productModel);
        }
        
        public async Task<IActionResult> SaveEdit(ProductModel productModel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(productModel), Encoding.UTF8, "application/json");
            if(await MVCHelper.PostAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/Edit/"), content))
            {

                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }
        public async Task<IActionResult> Delete(int productId)
        {
            if(await MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/Delete/" , productId)) == "true")
            {
                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }
        public async Task<IActionResult> Create()
        {
            ProductModel productModel = JsonConvert.DeserializeObject<ProductModel>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/CreateProduct/")));
            return View(productModel);
        }
        public async Task<IActionResult> CreateNew(ProductModel productModel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(productModel), Encoding.UTF8, "application/json");
            if (await MVCHelper.PostAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/SaveCreate/"), content))
            {
                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }
       
        public async Task<ActionResult> GetProductsByCategory(int categoryId)
        {
            ProductModel productModel = new ProductModel();
            productModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}/{1}", configuration.GetSection("baseUrl").Value +"api/GetProductsByCategory", categoryId)));
            return PartialView("_Product", productModel);
        }
       
        public async Task<ActionResult> Search(string searchBy)
        {
            ProductModel productModel = new ProductModel();
            productModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/Search/" , searchBy)));
            return PartialView("_Product", productModel);
        }
        public async Task<ActionResult> PriceRange(int min,int max)
        {
            ProductModel productModel = new ProductModel();
            productModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}{1}/{2}", configuration.GetSection("baseUrl").Value + "api/PriceRange/" , min , max)));
            return PartialView("_Product", productModel);
        }
        public async Task<ActionResult> ProductDetail(int productId)
        {
            ProductModel productModel = JsonConvert.DeserializeObject<ProductModel>(await MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/ProductDetail/" , productId)));
            productModel.listCategory = JsonConvert.DeserializeObject<List<CategoriesModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetCategories")));
            return View(productModel);
        }
        public void ProductToSession(int productId,int sessionQuantity = 1)
        {
            ProductModel productModel = JsonConvert.DeserializeObject<ProductModel>(MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/ProductDetail/", productId)).Result);
            productModel.SessionQuantity = sessionQuantity;
            productModel.SessionPrice = sessionQuantity * productModel.SalePrice;

            string sessionKey = MethodHelper.IsThereSomeone(HttpContext.Session);
            var listSession = SessionHelper.GetObjectFromJson<List<ProductModel>>(HttpContext.Session, sessionKey)?? new List<ProductModel>();
           
            listSession.Add(productModel);
            
            SessionHelper.SetObjectAsJson(HttpContext.Session, sessionKey, listSession);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "card", listSession.Count);
        }
        public async Task<ActionResult> SortBy(string sortBy)
        {
            ProductModel productModel = new ProductModel();
            productModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}{1}", configuration.GetSection("baseUrl").Value + "api/SortBy/", sortBy)));
            return PartialView("_Products", productModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    ProductBsn productBsn = new ProductBsn();
        //    dynamic mymodel = new ExpandoObject();
        //    mymodel.Products = await productBsn.GetListProduct();
        //    mymodel.Categories = await productBsn.GetListCategory();
        //    return View(mymodel);
        //}
        [HttpGet]
        [Route("api/GetProducts")]
        public async Task<List<ProductModel>> GetProductsApi()
        {
            ProductBsn productBsn = new ProductBsn();
            var products =await productBsn.GetListProduct();
            return products;
        }

        [HttpGet]
        [Route("api/GetCategories")]
        public async Task<List<CategoriesModel>> GetCategories()
        {
            var productBsn = new ProductBsn();
            List<CategoriesModel> categories = await productBsn.GetListCategory();
            return categories;
        }

        [HttpGet]
        [Route("api/GetBrands")]
        public async Task<List<BrandsModel>> GetBrands()
        {
            var productBsn = new ProductBsn();
            List<BrandsModel> brands = productBsn.GetListBrand();
            return brands;
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        [HttpGet]
        [Route("api/CreateProduct/")]
        public async Task<ProductModel> Create()
        {
            ProductBsn productBsn = new ProductBsn();
            ProductModel productModel = new ProductModel();
            productModel.listCategory = await productBsn.GetListCategory();
            productModel.listBrand = productBsn.GetListBrand();
            return productModel;
        }

        // POST: ProductController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/SaveCreate/")]
        public bool Create([FromBody] ProductModel productModel)
        {
            ProductBsn productBsn = new ProductBsn();
            var result = productBsn.Insert(productModel);
            return result;
        }

        // GET: ProductController/Edit/5
        [HttpGet]
        [Route("api/EditProduct/{productId}")]
        public async Task<ProductModel> Edit(int productId)
        {
            ProductBsn productBsn = new ProductBsn();
            ProductModel productModel =await productBsn.GetProductById(productId);
            return productModel;
        }

        // POST: api/Edit/
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/Edit/")]
        public bool Edit([FromBody]ProductModel productModel)
        {
                ProductBsn productBsn = new ProductBsn();
                var result =  productBsn.Update(productModel);
                return result;
        }

        //GET: ProductController/Delete/5
        [HttpGet]
        [Route("api/Delete/{productId}")]
        public bool Delete(int productId)
        {
            ProductBsn productBsn = new ProductBsn();
            var result = productBsn.Delete(productId);
            return result;
        }
        [HttpGet]
        [Route("api/GetProductsByCategory/{categoryId}")]
        public async Task<List<ProductModel>> GetProductsByCategory(int categoryId)
        {
            ProductBsn productBsn = new ProductBsn();
            List<ProductModel> products = productBsn.GetProductsByCategory(categoryId);
            return products;
        }
        [HttpGet]
        [Route("api/Search/{searchBy}")]
        public async Task<List<ProductModel>> Search(string searchBy)
        {
            ProductBsn productBsn = new ProductBsn();
            List<ProductModel> products = productBsn.Search(searchBy);
            return products;
        }
        [HttpGet]
        [Route("api/PriceRange/{min}/{max}")]
        public async Task<List<ProductModel>> PriceRange(int min, int max)
        {
            ProductBsn productBsn = new ProductBsn();
            List<ProductModel> products =await productBsn.PriceRange(min,max);
            return products;
        }
        [HttpGet]
        [Route("api/ProductDetail/{productId}")]
        public async Task<ProductModel> ProductDetail(int productId)
        {
            ProductBsn productBsn = new ProductBsn();
            ProductModel product =await productBsn.ProductDetail(productId);
            return product;
        }
        [HttpGet]
        [Route("api/SortBy/{sortBy}")]
        public async Task<List<ProductModel>> SortBy(string sortBy)
        {
            ProductBsn productBsn = new ProductBsn();
            List<ProductModel> products = productBsn.SortBy(sortBy);
            return products;
        }
    }
}

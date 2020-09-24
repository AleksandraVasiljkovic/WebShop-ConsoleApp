using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShopMVC.Controllers
{
    public class ShoppingCardController : Controller
    {
        private IConfiguration configuration;
        private UserModel userSession;
        public ShoppingCardController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        // GET: ShoppingCard
        public async Task<IActionResult> Index()
        {
            string sessionKey = MethodHelper.IsThereSomeone(HttpContext.Session);
            List<ProductModel> productFromSessionCard= SessionHelper.GetObjectFromJson<List<ProductModel>>(HttpContext.Session, sessionKey);
            if (productFromSessionCard != null) { return View(productFromSessionCard); }
            return View();
            //List<OrderLineModel> orderLineModel = JsonConvert.DeserializeObject<List<OrderLineModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetOrdersLine")));
            //var sum = orderLineModel.Sum(x => x.Price);
            //return View(orderLineModel);
        }
        public async Task<IActionResult> Checkout()
        {
            string sessionKey = MethodHelper.IsThereSomeone(HttpContext.Session);
            userSession = SessionHelper.GetObjectFromJson<UserModel>(HttpContext.Session, "userObject");
            if (userSession != null)
            {
                List<ProductModel> productFromSessionCard = SessionHelper.GetObjectFromJson<List<ProductModel>>(HttpContext.Session, sessionKey);
                StringContent content = new StringContent(JsonConvert.SerializeObject(productFromSessionCard), Encoding.UTF8, "application/json");
                CheckoutModel checkoutModel= JsonConvert.DeserializeObject<CheckoutModel>(await MVCHelper.PostLoginAPI(configuration.GetSection("baseUrl").Value + "api/ProductToCard/" + sessionKey,content));
                HttpContext.Session.Remove("card");
                return View("Checkout",checkoutModel);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            
        }

        // GET: ShoppingCard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoppingCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoppingCard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoppingCard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

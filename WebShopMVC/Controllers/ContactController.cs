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
    public class ContactController : Controller
    {
        private IConfiguration configuration;
        public ContactController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactModel contactModel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(contactModel), Encoding.UTF8, "application/json");
            if (await MVCHelper.PostAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/SaveContact/"), content))
            {
                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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

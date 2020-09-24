using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebShop.Bsn;
using WebShop.Model;



namespace WebShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration iConfig)
        {
            _logger = logger;
            configuration = iConfig;
        }

        public async Task<IActionResult> Index()
        {
            ProductModel productsModel = new ProductModel();
            productsModel.listProducts = JsonConvert.DeserializeObject<List<ProductModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetProducts")));
            productsModel.listCategory = JsonConvert.DeserializeObject<List<CategoriesModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetCategories")));
            return View(productsModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

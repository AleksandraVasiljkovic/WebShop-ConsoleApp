using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace WebShopMVC.Controllers
{
    public class LoginController : Controller
    {
        private IConfiguration configuration;
        public LoginController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }
        public async Task<IActionResult> LoginSave(LoginModel loginModel)
        {
            
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json");
            UserModel userModel = JsonConvert.DeserializeObject<UserModel>(await MVCHelper.PostLoginAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/LoginSave/"), content));
            if (userModel  != null)
            {
                SessionHelper.SetObjectAsJson(HttpContext.Session, "userObject", userModel);
                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }
        public async Task<IActionResult> Register()
        {
            return View();
        }
        public async Task<IActionResult> RegisterSave(UserModel userModel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(userModel), Encoding.UTF8, "application/json");
            if (await MVCHelper.PostAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/RegisterSave/"), content))
            {
                return RedirectToAction("Index", "Products");
            }
            return RedirectToAction("Index", "Products");
        }
    }
}

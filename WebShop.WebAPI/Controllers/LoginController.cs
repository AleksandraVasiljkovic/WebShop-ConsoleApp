using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/LoginSave/")]
        public UserModel LoginSave([FromBody] LoginModel loginModel)
        {
            UserBsn userBsn = new UserBsn();
            UserModel userModel = userBsn.True(loginModel);
            return userModel;
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("api/RegisterSave/")]
        public bool RegisterSave([FromBody] UserModel userModel)
        {
            UserBsn userBsn = new UserBsn();
            var result = userBsn.Insert(userModel);
            return result;
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebShopMVC
{
    public static class MethodHelper 
    {
        
        private static UserModel userSession;
        private static string sessionKey;
        public static string IsThereSomeone(this ISession session)
        {
            userSession = SessionHelper.GetObjectFromJson<UserModel>(session, "userObject");
            sessionKey = userSession != null ? userSession.UserId.ToString() : session.Id.ToString();
            return sessionKey;
        }
    }
}

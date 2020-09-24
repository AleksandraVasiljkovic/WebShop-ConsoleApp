using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebShop.Model;

namespace WebShopMVC
{
    public static class SessionHelper
    {
        
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
        public static int GetListCountOrderLine(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? 0 : Convert.ToInt32(value);
        }
        public static string GetLog(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (value != null)
            {
            UserModel userModel = JsonConvert.DeserializeObject<UserModel>(value);
                return userModel.Name;
            }
            return "Login";
        }
    }
}

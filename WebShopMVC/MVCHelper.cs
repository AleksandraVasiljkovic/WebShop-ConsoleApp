using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebShop.Model;

namespace WebShopMVC
{
    public static class MVCHelper
    {
        public static async Task<string> GetAPI(string url)
        {
            string apiUrl = url;
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    data= await response.Content.ReadAsStringAsync();
                }
                return data;
            }
        }
        public static async Task<bool> PostAPI(string url, StringContent content)
        {
            string apiUrl = url;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
        public static async Task<string> PostLoginAPI(string url, StringContent content)
        {
            string apiUrl = url;
            string data = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }
                return data;
            }
        }
        //public Task<HttpResponseMessage> PostAsyncTask(string url, object model)
        //{
        //    client.SetBearerToken(_httpContextAccessor?.HttpContext);
        //    var oid = Guid.NewGuid().ToString();
        //    client.DefaultRequestHeaders.Remove("oid");
        //    client.DefaultRequestHeaders.Add("oid", oid);
        //    var userString = _httpContextAccessor?.HttpContext?.Session?.GetString(SessionType.User.ToString());
        //    if (!string.IsNullOrEmpty(userString))
        //    {
        //        var user = JsonConvert.DeserializeObject<Domain.SessionUser>(userString);
        //        client.DefaultRequestHeaders.Remove("httpUser");
        //        client.DefaultRequestHeaders.Add("httpUser", user.Username);
        //    }
        //    else
        //    {
        //        ClaimsPrincipal cp = _httpContextAccessor?.HttpContext?.User as ClaimsPrincipal;
        //        string username = cp?.FindFirst("name")?.Value;
        //        //Request headers must contain only ASCII chatacters
        //        if (!string.IsNullOrEmpty(username))
        //        {
        //            username = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(username));
        //            client.DefaultRequestHeaders.Remove("httpUser");
        //            client.DefaultRequestHeaders.Add("httpUser", username);
        //            //Serilog.Log.Information(string.Format("User: {0} - API: {1}", username, url));
        //        }
        //    }
        //    string json = model.GetType() == typeof(string) ? model.ToString() : JsonConvert.SerializeObject(model);
        //    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        //    var response = client.PostAsync(url, stringContent);
        //    return response;
        //}
    }
}

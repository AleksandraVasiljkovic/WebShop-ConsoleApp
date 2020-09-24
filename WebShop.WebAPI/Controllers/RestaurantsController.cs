using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class RestaurantsController: Controller
    {
        [HttpGet]
        [Route("api/GetRestaurants")]
        public async Task<List<RestaurantsModel>> GetRestaurants()
        {
            RestaurantsBsn restaurantsBsn = new RestaurantsBsn();
            var restaurants =await restaurantsBsn.Read();
            return restaurants;
        }
    }
}

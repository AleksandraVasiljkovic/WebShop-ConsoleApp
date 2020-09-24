using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace WebShop.Data
{
    public class RestaurantsJSON : IRestaurantsData
    {
        public void DeleteRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertRestaurant(RestaurantsModel restaurantsModel)
        {
            string curFile = @"C:\temp\Restaurants.json";
            if (File.Exists(curFile))
            {
                List<RestaurantsModel> listRestaurants = ReadRestaurants();
                listRestaurants.Add(restaurantsModel);
                var jsonString = JsonSerializer.Serialize(listRestaurants);
                File.WriteAllText("C:\\temp\\Restaurants.json", jsonString);

            }
            else
            {
                List<RestaurantsModel> listRestaurants = new List<RestaurantsModel>();
                listRestaurants.Add(restaurantsModel);
                var jsonString = JsonSerializer.Serialize(listRestaurants);
                File.WriteAllText("C:\\temp\\Restaurants.json", jsonString);
            }
        }

        public List<RestaurantsModel> ReadRestaurants()
        {
            var jsonString = File.ReadAllText("C:\\temp\\Restaurants.json");
            List<RestaurantsModel> listRestaurants = JsonSerializer.Deserialize<List<RestaurantsModel>>(jsonString);
            return listRestaurants;
        }

        public void UpdateRestaurant(RestaurantsModel restaurantsModel)
        {
            throw new NotImplementedException();
        }
    }
}

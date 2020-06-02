using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Bsn
{
    public class RestaurantsBsn
    {
        public IRestaurantsData restaurantsData;
        public RestaurantsBsn()
        {
            restaurantsData = new RestaurantsData();
            if (Source.DataStorage == 1)
            {
                restaurantsData = new RestaurantsJSON();
            }
        }
        public List<RestaurantsModel> Read()
        {
            List<RestaurantsModel> RestaurantsList = new List<RestaurantsModel>();
            return restaurantsData.ReadRestaurants();
            

        }
        public void Insert(RestaurantsModel restaurantsModel)
        {
            restaurantsData.InsertRestaurant(restaurantsModel);
        }
        public void Update(int id, RestaurantsModel restaurantsModel)
        {

            restaurantsData.UpdateRestaurant(id, restaurantsModel);
        }

        public void Delete(int id)
        {

            restaurantsData.DeleteRestaurant(id);
        }
    }
}

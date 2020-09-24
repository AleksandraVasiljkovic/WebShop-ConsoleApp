using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class RestaurantsBsn
    {
        public IRestaurantsData restaurantsData;
        public RestaurantsBsn()
        {
            restaurantsData = new RestaurantsEFData();
            if (Source.DataStorage == 1)
            {
                restaurantsData = new RestaurantsJSON();
            }
        }
        public async Task<List<RestaurantsModel>> Read()
        {
            List<RestaurantsModel> restaurantsList = restaurantsData.ReadRestaurants();
            return restaurantsList;
        }
        public void Insert(RestaurantsModel restaurantsModel)
        {
            restaurantsData.InsertRestaurant(restaurantsModel);
        }
        public void Update(RestaurantsModel restaurantsModel)
        {

            restaurantsData.UpdateRestaurant(restaurantsModel);
        }

        public void Delete(int id)
        {

            restaurantsData.DeleteRestaurant(id);
        }
    }
}

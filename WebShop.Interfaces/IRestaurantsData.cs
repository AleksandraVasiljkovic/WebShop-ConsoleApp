using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IRestaurantsData
    {
        List<RestaurantsModel> ReadRestaurants();

        void InsertRestaurant(RestaurantsModel restaurantsModel);
        void UpdateRestaurant(RestaurantsModel restaurantsModel);

        void DeleteRestaurant(int id);
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class RestaurantsEFData : IRestaurantsData
    {
        public void DeleteRestaurant(int id)
        {
            using (var context = new WebShopContext())
            {
                context.Remove(context.RestaurantsModel.Select(p => p.RestaurantId == id));
                context.SaveChanges();
            }
        }

        public void InsertRestaurant(RestaurantsModel restaurantsModel)
        {
            using (var context = new WebShopContext())
            {
                context.RestaurantsModel.Add(restaurantsModel);
                context.SaveChanges();
            }
        }

        public List<RestaurantsModel> ReadRestaurants()
        {
            using (var context = new WebShopContext())
            {
                List<RestaurantsModel> restaurants = context.RestaurantsModel.ToList();
                return restaurants;
            }
        }

        public void UpdateRestaurant(RestaurantsModel restaurantsModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.RestaurantsModel.SingleOrDefault(b => b.RestaurantId == restaurantsModel.RestaurantId);
                if (result != null)
                {
                    try
                    {
                        context.RestaurantsModel.Attach(restaurantsModel);
                        context.Entry(restaurantsModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}

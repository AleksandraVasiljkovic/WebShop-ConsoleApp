using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Model
{
    public class RestaurantsModel
    {
        public int? RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Description { get; set; }
        public RestaurantsModel()
        {

        }
        public RestaurantsModel(string name, string address, string webSite, string description)
        {
            RestaurantId = null;
            Name = name;
            Address = address;
            WebSite = webSite;
            Description = description;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Address + " " + this.WebSite + " " + this.Description;
        }
    }
}

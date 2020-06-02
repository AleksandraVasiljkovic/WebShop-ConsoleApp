using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Model
{
    public class BrandsModel
    {
        public int? BrandId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public BrandsModel()
        {

        }
        public BrandsModel(string name, string country)
        {
            BrandId = null;
            Name = name;
            Country = country;
            
        }

        public override string ToString()
        {
            return this.Name + " " + this.Country;
        }

    }
}

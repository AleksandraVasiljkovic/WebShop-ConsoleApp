using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Model
{
    public class CategoriesModel
    {
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoriesModel()
        {

        }
        public CategoriesModel(string name, string description)
        {
            CategoryId = null;
            Name = name;
            Description = description;
            
        }
        public override string ToString()
        {
            return this.Name + " " + this.Description;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Model
{
    public class RecipesModel
    {
        public int? RecipesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipesModel()
        {

        }
        public RecipesModel(string name, string description)
        {
            RecipesId = null;
            Name = name;
            Description = description;
            
        }
        public override string ToString()
        {
            return this.Name + " " + this.Description;
        }
    }
}

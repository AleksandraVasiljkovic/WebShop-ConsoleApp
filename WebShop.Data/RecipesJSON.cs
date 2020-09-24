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
    public class RecipesJSON : IRecipesData
    {
        public void DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertRecipe(RecipesModel recipesModel)
        {
            string curFile = @"C:\temp\Recipes.json";
            if (File.Exists(curFile))
            {
                List<RecipesModel> listRecipes = ReadRecipes();
                listRecipes.Add(recipesModel);
                var jsonString = JsonSerializer.Serialize(listRecipes);
                File.WriteAllText("C:\\temp\\Recipes.json", jsonString);
            }
            else
            {
                List<RecipesModel> listRecipes = new List<RecipesModel>();
                listRecipes.Add(recipesModel);
                var jsonString = JsonSerializer.Serialize(listRecipes);
                File.WriteAllText("C:\\temp\\Recipes.json", jsonString);
            }
        }
        public List<RecipesModel> ReadRecipes()
        {
            string jsonString = File.ReadAllText("C:\\temp\\Recipes.json");
            List<RecipesModel> listRecipes = JsonSerializer.Deserialize<List<RecipesModel>>(jsonString);
            return listRecipes;
        }

        public void UpdateRecipe(RecipesModel recipesModel)
        {
            throw new NotImplementedException();
        }
    }
}

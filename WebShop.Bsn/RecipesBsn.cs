using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
namespace WebShop.Bsn
{
    public class RecipesBsn
    {
        public IRecipesData recipesData;
        public RecipesBsn()
        {
            recipesData = new RecipesData();
            if (Source.DataStorage == 1)
            {
                recipesData = new RecipesJSON();
            }
        }
        public List<RecipesModel> Read()
        {
            List<RecipesModel> recipesList = new List<RecipesModel>();
            return recipesData.ReadRecipes();
            

        }
        public void Insert(RecipesModel recipesModel)
        {
            recipesData.InsertRecipe(recipesModel);
        }
        public void Update(int id, RecipesModel recipesModel)
        {
            recipesData.UpdateRecipe(id, recipesModel);
        }

        public void Delete(int id)
        {
            recipesData.DeleteRecipe(id);
        }
    }
}

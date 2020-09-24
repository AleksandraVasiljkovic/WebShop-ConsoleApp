using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class RecipesBsn
    {
        public IRecipesData recipesData;
        public RecipesBsn()
        {
            recipesData = new RecipesEFData();
            if (Source.DataStorage == 1)
            {
                recipesData = new RecipesJSON();
            }
        }
        public async Task<List<RecipesModel>> Read()
        {
            List<RecipesModel> recipesList =recipesData.ReadRecipes();
            return recipesList;
        }
        public void Insert(RecipesModel recipesModel)
        {
            recipesData.InsertRecipe(recipesModel);
        }
        public void Update(RecipesModel recipesModel)
        {
            recipesData.UpdateRecipe(recipesModel);
        }

        public void Delete(int id)
        {
            recipesData.DeleteRecipe(id);
        }
    }
}

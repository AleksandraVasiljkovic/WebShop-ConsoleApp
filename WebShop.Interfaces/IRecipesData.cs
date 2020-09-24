using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IRecipesData
    {
        List<RecipesModel> ReadRecipes();

        void InsertRecipe(RecipesModel recipesModel);
        void UpdateRecipe(RecipesModel recipesModel);

        void DeleteRecipe(int id);
    }
}

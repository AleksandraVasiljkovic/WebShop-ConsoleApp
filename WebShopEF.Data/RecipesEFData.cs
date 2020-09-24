using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class RecipesEFData : IRecipesData
    {
        public void DeleteRecipe(int id)
        {
            using (var context = new WebShopContext())
            {
                context.Remove(context.RecipesModel.Select(p => p.RecipeId == id));
                context.SaveChanges();
            }
        }

        public void InsertRecipe(RecipesModel recipesModel)
        {
            using (var context = new WebShopContext())
            {
                context.RecipesModel.Add(recipesModel);
                context.SaveChanges();
            }
        }

        public List<RecipesModel> ReadRecipes()
        {
            using (var context = new WebShopContext())
            {
                List<RecipesModel> recipes = context.RecipesModel.ToList();
                return recipes;
            }
        }

        public void UpdateRecipe(RecipesModel recipesModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.RecipesModel.SingleOrDefault(b => b.RecipeId == recipesModel.RecipeId);
                if (result != null)
                {
                    try
                    {
                        context.RecipesModel.Attach(recipesModel);
                        context.Entry(recipesModel).State = EntityState.Modified;
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

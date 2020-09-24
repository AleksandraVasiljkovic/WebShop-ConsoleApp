using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShop.WebAPI.Controllers
{
    public class RecipesController: Controller
    {
        [HttpGet]
        [Route("api/GetRecipes")]
        public async Task<List<RecipesModel>> GetRecipes()
        {
            RecipesBsn recipesBsn = new RecipesBsn();
            var recipes =await recipesBsn.Read();
            return recipes;
        }
    }
}

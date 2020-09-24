using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class CategoriesEFData : ICategoriesData
    {
        public void DeleteCategory(int id)
        {
            using (var context = new WebShopContext())
            {
                context.Remove(context.CategoriesModel.Select(p => p.CategoryId == id));
                context.SaveChanges();
            }
        }

        public CategoriesModel getCategoryByName(string name)
        {
            using (var context = new WebShopContext())
            {
                CategoriesModel categorie = context.CategoriesModel.Where(p => p.Name == name).SingleOrDefault();
                return categorie;
            }
        }

        public void InsertCategory(CategoriesModel categoriesModel)
        {
            using (var context = new WebShopContext())
            {
                context.CategoriesModel.Add(categoriesModel);
                context.SaveChanges();
            }
        }

        public List<CategoriesModel> ReadCategories()
        {
            using (var context = new WebShopContext())
            {
                List<CategoriesModel> categories = context.CategoriesModel.ToList();
                return categories;
            }
        }

        public void UpdateCategory(CategoriesModel categoriesModel)
        {
            using (var context = new WebShopContext())
            { 
                var result = context.CategoriesModel.SingleOrDefault(b => b.CategoryId == categoriesModel.CategoryId);
                if (result != null)
                {
                    try
                    {
                        context.CategoriesModel.Attach(categoriesModel);
                        context.Entry(categoriesModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}

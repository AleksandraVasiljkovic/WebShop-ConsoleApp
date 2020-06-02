using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Bsn
{
    public class CategoriesBsn
    {
        public ICategoriesData categoriesData;
        public CategoriesBsn()
        {
            categoriesData = new CategoriesData();
            if (Source.DataStorage == 1)
            {
                categoriesData = new CategoriesDataXML();
            }
        }
        public List<CategoriesModel> Read()
        {
            List<CategoriesModel> categoriesList = new List<CategoriesModel>();
            return categoriesData.ReadCategories();
            
            

        }
        public void Insert(CategoriesModel categoriesModel)
        {
            categoriesData.InsertCategory(categoriesModel);
        }
        public void Update(int id, CategoriesModel categoriesModel)
        {
            categoriesData.UpdateCategory(id, categoriesModel);
        }

        public void Delete(int id)
        {
            categoriesData.DeleteCategory(id);
        }
    }
}

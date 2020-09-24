using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class CategoriesBsn
    {
        public ICategoriesData categoriesData;
        public CategoriesBsn()
        {
            categoriesData = new CategoriesEFData();
            if (Source.DataStorage == 1)
            {
                categoriesData = new CategoriesDataXML();
            }
        }
        public async Task<List<CategoriesModel>> Read()
        {
            return categoriesData.ReadCategories();
        }
        public void Insert(CategoriesModel categoriesModel)
        {
            categoriesData.InsertCategory(categoriesModel);
        }
        public void Update(CategoriesModel categoriesModel)
        {
            categoriesData.UpdateCategory(categoriesModel);
        }

        public void Delete(int id)
        {
            categoriesData.DeleteCategory(id);
        }
        public CategoriesModel getCategoryByNameBsn(string name)
        {
            CategoriesModel categoriesModel = categoriesData.getCategoryByName(name);
            return categoriesModel;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface ICategoriesData
    {
        List<CategoriesModel> ReadCategories();

        void InsertCategory(CategoriesModel categoriesModel);
        void UpdateCategory(CategoriesModel categoriesModel);

        void DeleteCategory(int id);
        CategoriesModel getCategoryByName(string name);

    }
}

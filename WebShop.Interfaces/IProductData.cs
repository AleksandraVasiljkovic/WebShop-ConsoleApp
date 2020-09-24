using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IProductData
    {
        List<ProductModel> ReadProducts();

        void InsertProduct(ProductModel productModel);

        void UpdateProduct(ProductModel productModel);

        void DeleteProduct(int id);
        List<ProductModel> GetProductsByCategory(int id);
        List<ProductModel> Search(string searchBy);
        ProductModel ProductDetail(int productId);
        List<ProductModel> PriceRange(int min, int max);
        List<ProductModel> SortBy(string sortBy);
    }
}

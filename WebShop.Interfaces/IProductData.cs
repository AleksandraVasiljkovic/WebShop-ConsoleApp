using System;
using System.Collections.Generic;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IProductData
    {
        List<ProductModel> ReadProducts();

        void InsertProduct(ProductModel productModel);

        void UpdateProduct(int id, ProductModel productModel);

        void DeleteProduct(int id);


    }
}

using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Bsn
{
    public class ProductBsn
    {
        public IProductData productData;
        public ProductBsn()
        {
            productData = new ProductData();
        }
        public  List<ProductModel> Read()
        {
            List<ProductModel> productList = new List<ProductModel>();
            return productData.ReadProducts();
            
        }
        public void Insert(ProductModel productModel)
        {
            
            productData.InsertProduct(productModel);
        }
        
        public void Update(int idU, ProductModel productModel)
        {
            //List<ProductModel> productModels = Read();
            //int id = Convert.ToInt32(productModels[idU].ProductId);
            productData.UpdateProduct(idU, productModel);
        }

        public void Delete(int idD)
        {
            //List<ProductModel> productModels = Read();
            //int id = Convert.ToInt32(productModels[idD].ProductId);
            productData.DeleteProduct(idD);
        }


    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class ProductEFData : IProductData
    {
        public void DeleteProduct(int id)
        {
            using(var context = new WebShopContext())
            {
                context.Remove(context.ProductModel.Select(p => p.ProductId == id));
                context.SaveChanges();
            }
        }

        public List<ProductModel> GetProductsByCategory(int id)
        {
            using(var context = new WebShopContext())
            {
                List<ProductModel> products = context.ProductModel.Where(p => p.CategoryId == id).ToList();
                return products;
            }
        }

        public void InsertProduct(ProductModel productModel)
        {
            using (var context = new WebShopContext())
            {
                context.ProductModel.Add(productModel);
                context.SaveChanges();
            }
        }

        public List<ProductModel> ReadProducts()
        {
            using (var context = new WebShopContext())
            {
                List<ProductModel> products = context.ProductModel.ToList();
                return products;
            }
        }

        public List<ProductModel> Search(string searchBy)
        {
            using (var context = new WebShopContext())
            {
                List<ProductModel> products = context.ProductModel.Where(p => p.Name.Contains(searchBy)).ToList();
                return products;
            }
        }
        public List<ProductModel> PriceRange(int min, int max)
        {
            using (var context = new WebShopContext())
            {
                List<ProductModel> listProducts = context.ProductModel.Where(p => (p.SalePrice <= Convert.ToDecimal(max) && p.SalePrice >= Convert.ToDecimal(min)) && (p.Price <= Convert.ToDecimal(max) && p.Price >= Convert.ToDecimal(min))).ToList();
                return listProducts;
            }
        }
        public ProductModel ProductDetail(int productId)
        {
            using (var context = new WebShopContext())
            {
                ProductModel productModel = context.ProductModel.Where(p => p.ProductId == productId).FirstOrDefault();
                productModel.categoryModel = context.CategoriesModel.Where(p => p.CategoryId == productModel.CategoryId).FirstOrDefault();
                productModel.brandModel = context.BrandsModel.Where(p => p.BrandId == productModel.BrandId).FirstOrDefault();
                return productModel;
            }
        }

        public void UpdateProduct(ProductModel productModel)
        {
            using (var context = new WebShopContext())
            {
               
                    try
                    {
                       // context.ProductModel.Attach(productModel);
                        context.Entry(productModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
              
            }
        }
        public List<ProductModel> SortBy(string sortBy)
        {
            using (var context = new WebShopContext())
            {
                List<ProductModel> products;
                switch (sortBy)
                {
                    case "Name":
                        products = context.ProductModel.OrderBy(p => p.Name).ToList();
                        break;
                    case "Price":
                        products = context.ProductModel.OrderBy(p => p.SalePrice).ToList();
                        break;
                    default:
                        products = context.ProductModel.ToList();
                        break;
                }
                return products;
            }
        }
    }
}

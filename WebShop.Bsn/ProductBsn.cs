using Amazon.ECS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class ProductBsn
    {
        public IProductData productData;
        private CategoriesBsn categoriesBsn;
        private BrandsBsn brandsBsn;
        public ProductBsn()
        {
            productData = new ProductEFData();
            categoriesBsn = new CategoriesBsn();
            brandsBsn = new BrandsBsn();
        }
        
        public async Task<List<ProductModel>> Read()
        {
            return productData.ReadProducts();
        }
        public bool Insert(ProductModel productModel)
        {
            try
            {
                productData.InsertProduct(productModel);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public async Task<ProductModel> GetProductById(int productId)
        {
            List<ProductModel> productModels = await Read();
            ProductModel productModel = productModels.Where(p => p.ProductId == productId).FirstOrDefault();
            productModel.listCategory= await categoriesBsn.Read();
            productModel.listBrand =brandsBsn.Read();
            return productModel;
        }

        public bool Update(ProductModel productModel)
        {
            //List<ProductModel> productModels = Read();
            //int id = Convert.ToInt32(productModels[idU].ProductId);
            try
            {
                productData.UpdateProduct(productModel);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool Delete(int productId)
        {
            //List<ProductModel> productModels = Read();
            //int id = Convert.ToInt32(productModels[idD].ProductId);
            try
            {
                productData.DeleteProduct(productId);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ProductModel>> GetListProduct() 
        {
            List<ProductModel> productModels =await Read();
            List<CategoriesModel> listCategory = await GetListCategory();
            List<BrandsModel> listBrand =GetListBrand();
            foreach (var p in productModels)
            {
                p.categoryModel = listCategory.Where(c => c.CategoryId == p.CategoryId).FirstOrDefault();
                p.brandModel = listBrand.Where(c => c.BrandId == p.BrandId).FirstOrDefault();
            }
            return productModels;
        }
        public async Task<List<CategoriesModel>> GetListCategory()
        {
            ProductModel productModel = new ProductModel();
            productModel.listCategory = await categoriesBsn.Read();
            return productModel.listCategory;
        }
        public List<BrandsModel> GetListBrand()
        {
            ProductModel productModel = new ProductModel();
            productModel.listBrand = brandsBsn.Read();
            return productModel.listBrand;
        }
        public List<ProductModel> GetProductsByCategory(int id)
        {
            List<ProductModel> listProducts =productData.GetProductsByCategory(id);
            return listProducts;
        }

        public List<ProductModel> Search(string searchBy)
        {
            List<ProductModel> listSearch = productData.Search(searchBy);
            return listSearch;
        }
        public async Task<List<ProductModel>> PriceRange(int min, int max)
        {
            List<ProductModel> listProducts = productData.PriceRange(min,max);
            return listProducts;
        }
        public async Task<ProductModel> ProductDetail(int productId)
        {
            ProductModel productModel = productData.ProductDetail(productId);
            return productModel;
        }
        public List<ProductModel> SortBy(string sortBy)
        {
            List<ProductModel> listSortBy = productData.SortBy(sortBy);
            return listSortBy;
        }
    }
}

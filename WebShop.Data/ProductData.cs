using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebShop.Model;
using WebShop.Interfaces;
using System.Data;
using System.Threading.Tasks;

namespace WebShop.Data
{

    public class ProductData : BaseData, IProductData
    {
        public List<ProductModel> ReadProducts()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllProducts");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<ProductModel> productList = new List<ProductModel>();
                while (sqlDataReader.Read())
                {
                    ProductModel productModel = new ProductModel();
                    productModel.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                    productModel.Name = sqlDataReader["Name"].ToString();
                    productModel.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    productModel.BrandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                    productModel.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    productModel.Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    productModel.SalePrice = Convert.ToDecimal(sqlDataReader["SalePrice"]);
                    productList.Add(productModel);
                }
                return productList;
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }
            
        }

        public void InsertProduct(ProductModel productModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertProduct");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", productModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@CategoryId", productModel.CategoryId));
                sqlCommand.Parameters.Add(new SqlParameter("@BrandId", productModel.BrandId));
                sqlCommand.Parameters.Add(new SqlParameter("@Quantity", productModel.Quantity));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", productModel.Price));
                sqlCommand.Parameters.Add(new SqlParameter("@SalePrice", productModel.SalePrice));
                ExecutedNonQuery();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }

        }

        public void UpdateProduct( ProductModel productModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateProduct");
                sqlCommand.Parameters.Add(new SqlParameter("@ProductId", productModel.ProductId));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", productModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@CategoryId", productModel.CategoryId));
                sqlCommand.Parameters.Add(new SqlParameter("@BrandId", productModel.BrandId));
                sqlCommand.Parameters.Add(new SqlParameter("@Quantity", productModel.Quantity));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", productModel.Price));
                sqlCommand.Parameters.Add(new SqlParameter("@SalePrice", productModel.SalePrice));
                ExecutedNonQuery();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }

        }

        public void DeleteProduct(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteProduct");
                sqlCommand.Parameters.Add(new SqlParameter("@ProductId", id));
                ExecutedNonQuery();
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }

        }
        public List<ProductModel> GetProductsByCategory(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("GetProductsByCategory");
                sqlCommand.Parameters.Add(new SqlParameter("@CategoryId", id));
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<ProductModel> productList = new List<ProductModel>();
                while (sqlDataReader.Read())
                {
                    ProductModel productModel = new ProductModel();
                    productModel.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                    productModel.Name = sqlDataReader["Name"].ToString();
                    productModel.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    productModel.BrandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                    productModel.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    productModel.Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    productModel.SalePrice = Convert.ToDecimal(sqlDataReader["SalePrice"]);
                    productList.Add(productModel);
                }
                return productList;
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }
        }
        public List<ProductModel> Search(string searchBy)
        {
            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("Search");
                sqlCommand.Parameters.Add(new SqlParameter("@SearchBy", searchBy));
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<ProductModel> productList = new List<ProductModel>();
                while (sqlDataReader.Read())
                {
                    ProductModel productModel = new ProductModel();
                    productModel.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                    productModel.Name = sqlDataReader["Name"].ToString();
                    productModel.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    productModel.BrandId = Convert.ToInt32(sqlDataReader["BrandId"]);
                    productModel.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    productModel.Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    productModel.SalePrice = Convert.ToDecimal(sqlDataReader["SalePrice"]);
                    productList.Add(productModel);
                }
                return productList;
            }
            catch (SqlException ex)
            {
                throw new System.Exception(ex.Message);
            }
            finally
            {
                CloseSqlConnection();
            }
        }

        public ProductModel ProductDetail(int productId)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> PriceRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SortBy(string sortBy)
        {
            throw new NotImplementedException();
        }
    }
}


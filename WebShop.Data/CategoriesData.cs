using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class CategoriesData:BaseData, ICategoriesData
    {
        public List<CategoriesModel> ReadCategories()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllCategories");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<CategoriesModel> categoriesList = new List<CategoriesModel>();

                while (sqlDataReader.Read())
                {
                    CategoriesModel categoriesModel = new CategoriesModel();
                    categoriesModel.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    categoriesModel.Name = sqlDataReader["Name"].ToString();
                    categoriesModel.Description = sqlDataReader["Description"].ToString();
                    categoriesList.Add(categoriesModel);
                }
                return categoriesList;
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

        public void InsertCategory(CategoriesModel categoriesModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertCategory");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", categoriesModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", categoriesModel.Description));
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
        public void UpdateCategory(int id, CategoriesModel categoriesModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateCategory");
                sqlCommand.Parameters.Add(new SqlParameter("@CategoryId", id));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", categoriesModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", categoriesModel.Description));
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

        public void DeleteCategory(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteCategory");
                sqlCommand.Parameters.Add(new SqlParameter("@CategoryId", id));
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
    }
}

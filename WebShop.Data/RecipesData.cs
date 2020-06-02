using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebShop.Model;
using WebShop.Interfaces;

namespace WebShop.Data
{
    public class RecipesData: BaseData, IRecipesData
    {
        public List<RecipesModel> ReadRecipes()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllRecipes");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<RecipesModel> recipesList = new List<RecipesModel>();

                while (sqlDataReader.Read())
                {
                    RecipesModel recipesModel = new RecipesModel();
                    recipesModel.RecipesId = Convert.ToInt32(sqlDataReader["RecipesId"]);
                    recipesModel.Name = sqlDataReader["Name"].ToString();
                    recipesModel.Description = sqlDataReader["Description"].ToString();
                    recipesList.Add(recipesModel);
                }
                return recipesList;
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

        public void InsertRecipe(RecipesModel recipesModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertRecipe");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", recipesModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", recipesModel.Description));
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
        public void UpdateRecipe(int id, RecipesModel recipesModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateRecipe");
                sqlCommand.Parameters.Add(new SqlParameter("@RecipeId", id));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", recipesModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", recipesModel.Description));
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

        public void DeleteRecipe(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteRecipe");
                sqlCommand.Parameters.Add(new SqlParameter("@RecipeId", id));
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

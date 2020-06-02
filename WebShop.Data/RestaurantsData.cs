using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class RestaurantsData:BaseData, IRestaurantsData
    {
        public List<RestaurantsModel> ReadRestaurants()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllRestaurants");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<RestaurantsModel> restaurantsList = new List<RestaurantsModel>();

                while (sqlDataReader.Read())
                {
                    RestaurantsModel restaurantsModel = new RestaurantsModel();
                    restaurantsModel.RestaurantId = Convert.ToInt32(sqlDataReader["RestaurantId"]);
                    restaurantsModel.Name = sqlDataReader["Name"].ToString();
                    restaurantsModel.Address = sqlDataReader["Address"].ToString();
                    restaurantsModel.WebSite = sqlDataReader["WebSite"].ToString();
                    restaurantsModel.Description = sqlDataReader["Description"].ToString();
                    restaurantsList.Add(restaurantsModel);
                }
                return restaurantsList;
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

        public void InsertRestaurant(RestaurantsModel restaurantsModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertRestaurant");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", restaurantsModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", restaurantsModel.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@WebSite", restaurantsModel.WebSite));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", restaurantsModel.Description));
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
        public void UpdateRestaurant(int id, RestaurantsModel restaurantsModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateRestaurant");
                sqlCommand.Parameters.Add(new SqlParameter("@RestaurantId", id));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", restaurantsModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", restaurantsModel.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@WebSite", restaurantsModel.WebSite));
                sqlCommand.Parameters.Add(new SqlParameter("@Description", restaurantsModel.Description));
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

        public void DeleteRestaurant(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteRestaurant");
                sqlCommand.Parameters.Add(new SqlParameter("@RestaurantId", id));
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

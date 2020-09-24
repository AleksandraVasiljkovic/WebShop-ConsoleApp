using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebShop.Model;
using WebShop.Interfaces;

namespace WebShop.Data
{
    public class UserData:BaseData, IUserData
    {
        public List<UserModel> ReadUsers()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllUsers");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<UserModel> userList = new List<UserModel>();

                while (sqlDataReader.Read())
                {
                    UserModel userModel = new UserModel();
                    userModel.UserId = Convert.ToInt32(sqlDataReader["UserId"]);
                    userModel.Name = sqlDataReader["Name"].ToString();
                    userModel.LastName = sqlDataReader["LastName"].ToString();
                    userModel.Address = sqlDataReader["Address"].ToString();
                    userModel.Contact = sqlDataReader["Contact"].ToString();
                    userModel.Email = sqlDataReader["Email"].ToString();
                    userList.Add(userModel);
                }
                return userList;
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

        public void InsertUser(UserModel userModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertUser");
                sqlCommand.Parameters.Add(new SqlParameter("@Name", userModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@LastName", userModel.LastName));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", userModel.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@Contact", userModel.Contact));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", userModel.Email));
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

        public void UpdateUser(UserModel userModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateUser");
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", userModel.UserId));
                sqlCommand.Parameters.Add(new SqlParameter("@Name", userModel.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@LastName", userModel.LastName));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", userModel.Address));
                sqlCommand.Parameters.Add(new SqlParameter("@Contact", userModel.Contact));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", userModel.Email));
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

        public void DeleteUser(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteUser");
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", id));
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

        public UserModel GetUserByName(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public UserModel DeleteMaxId()
        {
            throw new NotImplementedException();
        }

        public UserModel DeleteMaxId(List<UserModel> user)
        {
            throw new NotImplementedException();
        }

        public UserModel True(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }
    }
}

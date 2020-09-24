using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class OrdersData: BaseData, IOrdersData
    {
        public List<OrdersModel> ReadOrders()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllOrders");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<OrdersModel> ordersList = new List<OrdersModel>();

                while (sqlDataReader.Read())
                {
                    OrdersModel ordersModel = new OrdersModel();
                    ordersModel.OrderId = Convert.ToInt32(sqlDataReader["OrderId"]);
                    ordersModel.UserId = Convert.ToInt32(sqlDataReader["UserId"]);
                    ordersModel.Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    ordersModel.Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    ordersList.Add(ordersModel);
                }
                return ordersList;
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

        public void InsertOrder(OrdersModel ordersModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertOrder");
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", ordersModel.UserId));
                sqlCommand.Parameters.Add(new SqlParameter("@Date", ordersModel.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", ordersModel.Price));
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
        public void UpdateOrder(OrdersModel ordersModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateOrder");
                sqlCommand.Parameters.Add(new SqlParameter("@OrderId", ordersModel.OrderId));
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", ordersModel.UserId));
                sqlCommand.Parameters.Add(new SqlParameter("@Date", ordersModel.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", ordersModel.Price));
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

        public void DeleteOrder(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteOrder");
                sqlCommand.Parameters.Add(new SqlParameter("@OrderId", id));
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

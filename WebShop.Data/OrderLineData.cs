using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Data
{
    public class OrderLineData : BaseData, IOrderLineData
    {
        public List<OrderLineModel> ReadOrderLines()
        {
            try
            {
                OpenSqlConnection();
                CreateCommandSc("SelectAllOrderLines");
                SqlDataReader sqlDataReader = GetExecuteReader();

                List<OrderLineModel> productList = new List<OrderLineModel>();

                while (sqlDataReader.Read())
                {
                    OrderLineModel orderLineModel = new OrderLineModel();
                    orderLineModel.OrderLineId = Convert.ToInt32(sqlDataReader["OrderLineId"]);
                    orderLineModel.OrderId = Convert.ToInt32(sqlDataReader["OrderId"]);
                    orderLineModel.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                    orderLineModel.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);

                    productList.Add(orderLineModel);
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

        public void InsertOrderLine(OrderLineModel orderLineModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("InsertOrderLine");
                sqlCommand.Parameters.Add(new SqlParameter("@OrderId", orderLineModel.OrderId));
                sqlCommand.Parameters.Add(new SqlParameter("@ProductId", orderLineModel.ProductId));
                sqlCommand.Parameters.Add(new SqlParameter("@Quantity", orderLineModel.Quantity));
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
        public void UpdateOrderLine(int id, OrderLineModel orderLineModel)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("UpdateOrderLine");
                sqlCommand.Parameters.Add(new SqlParameter("@OrderLineId", id));
                sqlCommand.Parameters.Add(new SqlParameter("@OrderId", orderLineModel.OrderId));
                sqlCommand.Parameters.Add(new SqlParameter("@ProductId", orderLineModel.ProductId));
                sqlCommand.Parameters.Add(new SqlParameter("@Quantity", orderLineModel.Quantity));
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

        public void DeleteOrderLine(int id)
        {

            try
            {
                OpenSqlConnection();
                SqlCommand sqlCommand = CreateCommandSc("DeleteOrderLine");
                sqlCommand.Parameters.Add(new SqlParameter("@OrderLineId", id));
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

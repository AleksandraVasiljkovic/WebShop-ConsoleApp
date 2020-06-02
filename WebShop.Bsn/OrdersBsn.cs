using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;
using WebShopEF.Data;

namespace WebShop.Bsn
{
    public class OrdersBsn
    {
        public IOrdersData ordersData;
        public OrdersBsn()
        {
            ordersData = new OrdersEFData();
        }
        public List<OrdersModel> Read()
        {
            List<OrdersModel> ordersList = new List<OrdersModel>();
            return ordersData.ReadOrders();
            

        }
        public void Insert(OrdersModel ordersModel)
        {
            ordersData.InsertOrder(ordersModel);
        }
        public void Update(int id, OrdersModel ordersModel)
        {
            ordersData.UpdateOrder(id, ordersModel);
        }

        public void Delete(int id)
        {
            ordersData.DeleteOrder(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IOrdersData
    {
        List<OrdersModel> ReadOrders();

        void InsertOrder(OrdersModel ordersModel);
        void UpdateOrder(int id, OrdersModel ordersModel);

        void DeleteOrder(int id);
    }
}

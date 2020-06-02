using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class OrdersEFData : IOrdersData

    {
        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(OrdersModel ordersModel)
        {
            using (var context = new WebShopContext())
            {
                context.OrdersModel.Add(ordersModel);
                context.SaveChanges();
            }
        }

        public List<OrdersModel> ReadOrders()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int id, OrdersModel ordersModel)
        {
            throw new NotImplementedException();
        }
    }
    
}

using Microsoft.EntityFrameworkCore;
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
            using (var context = new WebShopContext())
            {
                context.Remove(context.OrdersModel.Select(p => p.OrderId == id));
                context.SaveChanges();
            }
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
            using (var context = new WebShopContext())
            {
                List<OrdersModel> orders = context.OrdersModel.ToList();
                return orders;
            }
        }

        public void UpdateOrder(OrdersModel ordersModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.OrdersModel.SingleOrDefault(b => b.OrderId == ordersModel.OrderId);
                if (result != null)
                {
                    try
                    {
                        context.OrdersModel.Attach(ordersModel);
                        context.Entry(ordersModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
    
}

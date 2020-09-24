using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShopEF.Data
{
    public class OrderLineEFData : IOrderLineData
    {
        public void DeleteOrderLine(int id)
        {
            using (var context = new WebShopContext())
            {
                context.Remove(context.OrderLineModel.Select(p => p.OrderLineId == id));
                context.SaveChanges();
            }
        }

        public void InsertOrderLine(OrderLineModel orderLineModel)
        {
            using (var context = new WebShopContext())
            {
                context.OrderLineModel.Add(orderLineModel);
                context.SaveChanges();
            }
        }
        public List<OrderLineModel> ReadOrderLines()
        {
            using (var context = new WebShopContext())
            {
                List<OrderLineModel> orderLines = context.OrderLineModel.ToList();
                foreach(var item in orderLines)
                {
                    item.Product = context.ProductModel.Where(p => p.ProductId == item.ProductId).FirstOrDefault();
                }
                return orderLines;
            }
        }

        public void UpdateOrderLine(OrderLineModel orderLineModel)
        {
            using (var context = new WebShopContext())
            {
                var result = context.OrderLineModel.SingleOrDefault(b => b.OrderLineId == orderLineModel.OrderLineId);
                if (result != null)
                {
                    try
                    {
                        context.OrderLineModel.Attach(orderLineModel);
                        context.Entry(orderLineModel).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
        public int OrderToBase(int userId,decimal totalPrice)
        {
            var dateTime = DateTime.Now;
            int orderId;
            using (var context = new WebShopContext())
            {
                    OrdersModel order = new OrdersModel(userId, dateTime, totalPrice );
                    context.OrdersModel.Add(order);
                    context.SaveChanges();
                    OrdersModel orderForUser = context.OrdersModel.Where(p => p.UserId == userId && p.Date == dateTime).FirstOrDefault();
                    orderId = orderForUser.OrderId;
            }
             return orderId;
        }
        public CheckoutModel ProductToCard(string sessionKey,List<ProductModel> productFromSessionCard)
        {   
            int userId=Convert.ToInt32(sessionKey);
            decimal totalPrice = productFromSessionCard.Sum(p=>p.SessionPrice);
            int orderId= OrderToBase(userId, totalPrice);
            using (var context = new WebShopContext())
            {
                foreach (ProductModel item in productFromSessionCard)
                {
                    OrderLineModel orderline = new OrderLineModel(orderId, item.ProductId, item.SessionQuantity, item.SessionPrice);
                    context.OrderLineModel.Add(orderline);
                }
                context.SaveChanges();
                CheckoutModel checkoutModel = new CheckoutModel();
                checkoutModel.orderLines = context.OrderLineModel.Where(p => p.OrderId == orderId).ToList();
                checkoutModel.order= context.OrdersModel.Where(p => p.OrderId == orderId).FirstOrDefault();
                checkoutModel.user = context.UserModel.Where(p => p.UserId == userId).FirstOrDefault();
                return checkoutModel;
            }
            
        }
    }
}

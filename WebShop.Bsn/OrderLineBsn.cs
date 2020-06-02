using System;
using System.Collections.Generic;
using WebShop.Data;
using WebShop.Interfaces;
using WebShop.Model;

namespace WebShop.Bsn
{
    public class OrderLineBsn
    {
        public IOrderLineData orderLineData;
        public OrderLineBsn()
        {
            orderLineData = new OrderLineData();
        }
        public List<OrderLineModel> Read()
        {
            List<OrderLineModel> orderLineList = new List<OrderLineModel>();
            return orderLineData.ReadOrderLines();
            

        }
        public void Insert(OrderLineModel orderLineModel)
        {
            orderLineData.InsertOrderLine(orderLineModel);
        }
        public void Update(int id, OrderLineModel orderLineModel)
        {
            orderLineData.UpdateOrderLine(id, orderLineModel);
        }

        public void Delete(int id)
        {
            orderLineData.DeleteOrderLine(id);
        }
    }
}

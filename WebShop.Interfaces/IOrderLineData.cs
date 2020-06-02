using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Model;

namespace WebShop.Interfaces
{
    public interface IOrderLineData
    {
        List<OrderLineModel> ReadOrderLines();

        void InsertOrderLine(OrderLineModel orderLineModel);
        void UpdateOrderLine(int id, OrderLineModel orderLineModel);

        void DeleteOrderLine(int id);
    }
}

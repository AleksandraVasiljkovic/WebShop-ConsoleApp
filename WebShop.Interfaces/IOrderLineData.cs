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
        void UpdateOrderLine(OrderLineModel orderLineModel);

        void DeleteOrderLine(int id);
        CheckoutModel ProductToCard(string sessionKey,List<ProductModel> productFromSessionCard);
        int OrderToBase(int userId, decimal totalPrice);
    }
}

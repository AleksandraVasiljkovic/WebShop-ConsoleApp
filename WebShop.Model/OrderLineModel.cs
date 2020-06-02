using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Model
{
    public class OrderLineModel
    {
        public int? OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderLineModel()
        {

        }
        public OrderLineModel(int orderId, int productId, int quantity)
        {
            OrderLineId = null;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            
        }
        public override string ToString()
        {
            return this.OrderId + " " + this.ProductId + " " + this.Quantity ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("OrderLine")]
    public class OrderLineModel
    {
        [Key]
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty(nameof(OrdersModel.OrderLine))]
        public virtual OrdersModel Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(ProductModel.OrderLine))]
        public virtual ProductModel Product { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int OrderLineId { get; set; }
        //public int OrderId { get; set; }
        //public int ProductId { get; set; }
        //[Required(ErrorMessage = "Enter Quantity")]
        //public int Quantity { get; set; }

        public OrderLineModel()
        {

        }
        public OrderLineModel(int orderId, int productId, int quantity, decimal price)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString()
        {
            return this.OrderId + " " + this.ProductId + " " + this.Quantity ;
        }

    }
}

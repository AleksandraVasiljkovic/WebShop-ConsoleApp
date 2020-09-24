using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Orders")]
    public class OrdersModel
    {
        public OrdersModel()
        {
            OrderLine = new HashSet<OrderLineModel>();
        }

        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UserModel.Orders))]
        public virtual UserModel User { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderLineModel> OrderLine { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int OrderId { get; set; }
        //[Column("UserId")]
        //public int UserId { get; set; }
        //[Required(ErrorMessage = "Enter Data")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime Date { get; set; }
        //[Required(ErrorMessage = "Enter Price")]
        //public double Price { get; set; }

        public OrdersModel(int userId, DateTime date, decimal price)
        {
            UserId = userId;
            Date = date;
            Price = price;
        }
        public override string ToString()
        {
            return this.UserId + " " + this.Date + " " + this.Price;
        }
    }
}

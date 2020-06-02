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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }


        public DateTime Date { get; set; }

        public double Price { get; set; }


        public OrdersModel()
        {

        }
        public OrdersModel(int userId, DateTime date, double price)
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

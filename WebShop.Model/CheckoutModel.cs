using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model
{
    public class CheckoutModel
    {
        [NotMapped]
        public UserModel user { get; set; }
        [NotMapped]
        public List<OrderLineModel> orderLines { get; set; }
        [NotMapped]
        public OrdersModel order { get; set; }
    }
}

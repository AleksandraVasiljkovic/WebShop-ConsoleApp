﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopMVC.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderLine = new HashSet<OrderLine>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderLine> OrderLine { get; set; }
    }
}
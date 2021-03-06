﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopMVC.Models
{
    public partial class Restaurants
    {
        [Key]
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Address { get; set; }
        [StringLength(50)]
        public string WebSite { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
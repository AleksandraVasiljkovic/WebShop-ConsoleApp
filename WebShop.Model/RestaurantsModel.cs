using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Restaurants")]
    public class RestaurantsModel
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
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int RestaurantId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(30, ErrorMessage = "Maximum length should be 30")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Enter Address")]
        //[DataType(DataType.Text)]
        //[StringLength(40, ErrorMessage = "Maximum length should be 40")]
        //public string Address { get; set; }
        //[DataType(DataType.Text)]
        //[StringLength(50, ErrorMessage = "Maximum length should be 50")]
        //public string WebSite { get; set; }
        //[DataType(DataType.Text)]
        //[StringLength(200, ErrorMessage = "Maximum length should be 200")]
        //public string Description { get; set; }
        public RestaurantsModel()
        {

        }
        public RestaurantsModel(string name, string address, string webSite, string description)
        {
            Name = name;
            Address = address;
            WebSite = webSite;
            Description = description;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Address + " " + this.WebSite + " " + this.Description;
        }
    }
}

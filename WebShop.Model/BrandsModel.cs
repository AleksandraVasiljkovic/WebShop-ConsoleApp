using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Brands")]
    public class BrandsModel
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string Country { get; set; }
        //public BrandsModel()
        //{
        //    //productModel = new HashSet<ProductModel>();
        //}
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int BrandId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(40, ErrorMessage = "Maximum length should be 40")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Enter Country")]
        //[DataType(DataType.Text)]
        //[StringLength(15, ErrorMessage = "Maximum length should be 15")]
        //public string Country { get; set; }

        ////[InverseProperty("BrandsModel")]
        //[NotMapped]
        //public ICollection<ProductModel> productModel { get; set; }
        public BrandsModel()
        {

        }
        public BrandsModel(string name, string country)
        {
            //BrandId = null;
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Country;
        }

    }
}

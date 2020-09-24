using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Categories")]
    public class CategoriesModel
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        //public CategoriesModel()
        //{
        //    //productModel = new HashSet<ProductModel>();
        //}
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int CategoryId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(15, ErrorMessage = "Maximum length should be 15")]
        //public string Name { get; set; }
        //[DataType(DataType.Text)]
        //[StringLength(200, ErrorMessage = "Maximum length should be 200")]
        //public string Description { get; set; }

        ////[InverseProperty("CategoriesModel")]
        //[NotMapped]
        //public ICollection<ProductModel> productModel { get; set; }
        public CategoriesModel()
        {

        }
        public CategoriesModel(string name, string description)
        {
            //CategoryId = null;
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Description;
        }

    }
}

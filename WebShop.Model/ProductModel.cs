using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model
{
    [Table("Products")]
    public class ProductModel
    {
        public ProductModel()
        {
            OrderLine = new HashSet<OrderLineModel>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public CategoriesModel categoryModel { get; set; }
        [NotMapped]
        public List<CategoriesModel> listCategory { get; set; }
        public int BrandId { get; set; }
        [NotMapped]
        public BrandsModel brandModel { get; set; }
        [NotMapped]
        public List<BrandsModel> listBrand { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderLineModel> OrderLine { get; set; }
        [NotMapped]
        public List<ProductModel> listProducts { get; set; }
        [NotMapped]
        public bool IsAdmin { get; set; }
        [NotMapped]
        public int SessionQuantity { get; set; }
        [NotMapped]
        public decimal SessionPrice { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int ProductId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(40, ErrorMessage = "Maximum length should be 40")]
        //public string Name { get; set; }
        //[ForeignKey("CategoriesModel")]
        //public int CategoryId { get; set; }
        //[NotMapped]
        //public CategoriesModel categoryModel { get; set; }
        //[NotMapped]
        //public List<CategoriesModel> listCategory { get; set; }
        //[ForeignKey("BrandsModel")]
        //public int BrandId { get; set; }
        //[NotMapped]
        //public BrandsModel brandModel { get; set; }
        //[NotMapped]
        //public List<BrandsModel> listBrand { get; set; }
        //[Required(ErrorMessage = "Enter Quantity")]
        //public int Quantity { get; set; }
        //[Required(ErrorMessage = "Enter Price")]
        //public decimal Price { get; set; }
        //[Required(ErrorMessage = "SalePrice")]
        //public decimal SalePrice { get; set; }
        //public List<ProductModel> listProducts { get; set; }

        //public byte[] Photo { get; set; }

        public ProductModel(string name, int categoryId, int brandId, int quantity , decimal price , decimal salePrice)
        {
            Name = name;
            CategoryId = categoryId;
            BrandId = brandId;
            Quantity = quantity;
            Price = price;
            SalePrice = salePrice;
        }

        public override string ToString()
        {
            return this.Name + " " + this.CategoryId + " " + this.BrandId + " " + this.Quantity+ " " + this.Price + " " + this.SalePrice;
        }

    }
}

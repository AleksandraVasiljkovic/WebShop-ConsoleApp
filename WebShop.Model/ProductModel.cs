using System;

namespace WebShop.Model
{
    public class ProductModel
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public ProductModel()
        {

        }
        public ProductModel(string name, int categoryId, int brandId, int quantity , decimal price)
        {
            ProductId = null;
            Name = name;
            CategoryId = categoryId;
            BrandId = brandId;
            Quantity = quantity;
            Price = price;
            
        }

        public override string ToString()
        {
            return this.Name + " " + this.CategoryId + " " + this.BrandId + " " + this.Quantity+ " " + this.Price;
        }

    }
}

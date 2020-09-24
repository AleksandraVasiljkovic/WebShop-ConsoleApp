using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebShop.Bsn;
using WebShop.Model;


namespace WebShopWF
{
    public partial class Products : Form
    {
        ProductBsn productBsn = new ProductBsn();
        ProductModel productModel = new ProductModel();
        public Products()
        {
            InitializeComponent();
            //GetCategories();
            //GetBrands();
        }
        //private void GetCategories()
        //{
        //    CategoriesBsn categoriesBsn = new CategoriesBsn();
        //    List<CategoriesModel> listCategories = categoriesBsn.Read();
        //    foreach (var x in listCategories)
        //    {
        //        comboBox1.Items.Add(x.Name);

        //    }
        //}
        //private void GetBrands()
        //{
        //    BrandsBsn brandsBsn = new BrandsBsn();
        //    List<BrandsModel> listBrands = brandsBsn.Read();
        //    foreach (var x in listBrands)
        //    {
        //        comboBox2.Items.Add(x.Name);

        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
            

        //    CategoriesBsn categoriesBsn = new CategoriesBsn();
        //    CategoriesModel categoriesModel = categoriesBsn.getCategoryByNameBsn(comboBox1.SelectedItem.ToString());
        //    int categoryId=Convert.ToInt32(categoriesModel.CategoryId);

        //    BrandsBsn brandsBsn = new BrandsBsn();
        //    BrandsModel brandsModel = brandsBsn.getBrandByNameBsn(comboBox2.SelectedItem.ToString());
        //    int brandId= Convert.ToInt32(brandsModel.BrandId);
            


        //    ProductModel productModel = new ProductModel(textBox1.Text,categoryId, brandId,Convert.ToInt32(textBox2.Text),Convert.ToDecimal(textBox3.Text));
        //    productBsn.Insert(productModel);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            
            List<ProductModel> productModels = productBsn.Read();
            foreach (var l in productModels)
            {
                listView1.Items.Add(l.Name.ToString());
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
            
        //    CategoriesBsn categoriesBsn = new CategoriesBsn();
        //    CategoriesModel categoriesModel = categoriesBsn.getCategoryByNameBsn(comboBox1.SelectedItem.ToString());
        //    int categoryId = Convert.ToInt32(categoriesModel.CategoryId);

        //    BrandsBsn brandsBsn = new BrandsBsn();
        //    BrandsModel brandsModel = brandsBsn.getBrandByNameBsn(comboBox2.SelectedItem.ToString());
        //    int brandId = Convert.ToInt32(brandsModel.BrandId);


        //    ProductModel productModelU = new ProductModel(textBox1.Text, categoryId, brandId, Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text));
        //    int idU = Convert.ToInt32(textBox4.Text);
        //    productBsn.Update(idU, productModelU);



        //}

        private void button4_Click(object sender, EventArgs e)
        {
            int idD = Convert.ToInt32(textBox4.Text); ;
            productBsn.Delete(idD);
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    string productName = " ";
        //    foreach (ListViewItem item in listView1.SelectedItems)
        //    {
                
        //        productName = item.Text;
        //    }

        //    List<ProductModel> productModel = productBsn.Read();
        //    ProductModel myProduct = productModel.Where(p => p.Name == productName).FirstOrDefault();

        //    textBox4.Text = myProduct.ProductId.ToString();
        //    textBox1.Text = myProduct.Name;

        //    CategoriesBsn categoriesBsn = new CategoriesBsn();
        //    List<CategoriesModel> categoryModel = categoriesBsn.Read();
        //    CategoriesModel myCategory = categoryModel.Where(c => c.CategoryId == myProduct.CategoryId).FirstOrDefault();
        //    comboBox1.SelectedItem = myCategory.Name;

        //    BrandsBsn brandBsn = new BrandsBsn();
        //    List<BrandsModel> brandModel = brandBsn.Read();
        //    BrandsModel myBrand = brandModel.Where(c => c.BrandId == myProduct.BrandId).FirstOrDefault();
        //    comboBox2.SelectedItem = myBrand.Name;

        //    textBox2.Text = myProduct.Quantity.ToString();
        //    textBox3.Text = myProduct.Price.ToString();


        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

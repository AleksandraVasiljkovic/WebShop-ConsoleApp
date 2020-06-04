using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShopWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestaurantsBsn restaurantsBsn = new RestaurantsBsn();
            List<RestaurantsModel> restaurantsModels = restaurantsBsn.Read();
            foreach (var l in restaurantsModels)
            {
                listView1.Items.Add(l.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurantsBsn restaurantsBsn = new RestaurantsBsn();
            RestaurantsModel restaurantsModel = new RestaurantsModel(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            restaurantsBsn.Insert(restaurantsModel);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


using WebShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopEF.Data
{
    public class WebShopContext:DbContext
    {
        public DbSet<UserModel> UserModel { get; set; }
        public DbSet<OrdersModel> OrdersModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SQA2M5U\SQLEXPRESS;Database=WebShop;Trusted_Connection=true");
        }
       
       

    }
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Model;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebShopEF.Data
{
    public partial class WebShopContext : DbContext
    {
        public WebShopContext()
        {
        }

        public WebShopContext(DbContextOptions<WebShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrandsModel> BrandsModel { get; set; }
        public virtual DbSet<CategoriesModel> CategoriesModel { get; set; }
        public virtual DbSet<ContactModel> ContactModel { get; set; }
        public virtual DbSet<OrderLineModel> OrderLineModel { get; set; }
        public virtual DbSet<OrdersModel> OrdersModel { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<RecipesModel> RecipesModel { get; set; }
        public virtual DbSet<RestaurantsModel> RestaurantsModel { get; set; }
        public virtual DbSet<UserModel> UserModel { get; set; }
        public virtual DbSet<LoginModel> LoginModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SQA2M5U\\SQLEXPRESS;Initial Catalog=WebShop;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); /*keys of Identity tables are mapped in OnModelCreating method of IdentityDbContext
                                                 * and if this method is not called, you will end up getting the error that you got.*/
            modelBuilder.Entity<BrandsModel>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__Brands__DAD4F05E9C56D65F");
            });

            modelBuilder.Entity<CategoriesModel>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Categori__19093A0B26446A75");
            });

            modelBuilder.Entity<ContactModel>(entity =>
            {
                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<OrderLineModel>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderLine__Order__6FE99F9F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderLine__Produ__70DDC3D8");
            });

            modelBuilder.Entity<OrdersModel>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BCF8F23EAD6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__UserId__4316F928");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6CD5BCD2785");
            });

            modelBuilder.Entity<RecipesModel>(entity =>
            {
                entity.HasKey(e => e.RecipeId)
                    .HasName("PK__Recipes__FDD988B02B257D50");
            });

            modelBuilder.Entity<RestaurantsModel>(entity =>
            {
                entity.HasKey(e => e.RestaurantId)
                    .HasName("PK__Restaura__87454C95AC9B2052");
            });

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4CBE4F9377");

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<LoginModel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
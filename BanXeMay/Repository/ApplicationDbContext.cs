using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BanXeMay.Models;


namespace BanXeMay.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data to table Categories
            modelBuilder.Entity<CategoryModel>().HasData(
            CategoryModel tayga= new CategoryModel {  Name = "Tay Ga",Slug="tayga",Description="Tay ga xe dom", Status = 1 },
            new CategoryModel { Name = "Xe So", Slug = "xeso", Description = "Tay ga xe dom", Status = 1 },
            //seed data to table Product
            modelBuilder.Entity<BrandModel>().HasData(
                new BrandModel { Name = "SUZUKI", Slug = "suzuki", Description = "Tay ga xe dom", Status = 1 },
                 new BrandModel { Name = "HONDA", Slug = "honda", Description = "Tay ga xe dom", Status = 1 },
            //seed data to table Product
            modelBuilder.Entity<ProductModel>().HasData(
            new ProductModel { Name = "Wave", Slug = "wave", Description = "Tay ga xe dom", Image= "gallery1.jpg",Category= },
            new Product { Id = 2, Name = "Iphone 7s", Price = 350, CategoryId = 1 },
            new Product { Id = 3, Name = "Iphone 8", Price = 400, CategoryId = 1 },
            new Product { Id = 4, Name = "Iphone 8s", Price = 420, CategoryId = 1 },
            new Product { Id = 5, Name = "Iphone 12", Price = 630, CategoryId = 1 },
            new Product { Id = 6, Name = "Iphone 12 Pro", Price = 750, CategoryId = 1 },
            new Product { Id = 7, Name = "Iphone 14", Price = 820, CategoryId = 1 },
            new Product { Id = 8, Name = "Iphone 14 Pro", Price = 950, CategoryId = 1 },
            new Product { Id = 9, Name = "Iphone 15", Price = 1200, CategoryId = 1 },
            new Product { Id = 10, Name = "Iphone 15 Pro Max ", Price = 1450, CategoryId = 1 },
            new Product { Id = 11, Name = "Ipad Gen 10", Price = 750, CategoryId = 2 },
            new Product { Id = 12, Name = "Ipad Pro 11", Price = 1250, CategoryId = 2 });
        }
    }
}

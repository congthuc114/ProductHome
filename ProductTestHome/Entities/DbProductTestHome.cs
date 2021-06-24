using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductTestHome.Entities
{
    public class DbProductTestHome:DbContext
    {
        public DbProductTestHome(DbContextOptions<DbProductTestHome> options) : base(options)
        {

        }

        // dùng tên Entities trong DbSet
        public DbSet<Product> Products { get; set; }

        // Seed những dữ liệu mẫu
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                
                new Product() { Id = 1, Name = "Nhà", price = "20000", photo = "https://i.ibb.co/0yfVm4t/download.jpg", datePro=DateTime.Now},
                new Product() { Id = 2, Name = "Tâm Lý Học", price = "25000", photo = "https://i.ibb.co/4jZTVnH/download.jpg", datePro = DateTime.Now }
                );
        }
    }
}

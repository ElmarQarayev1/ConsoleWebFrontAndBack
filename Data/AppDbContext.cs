using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
	public class AppDbContext:DbContext
	{
        public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ConsoleWeb1;User ID=sa; Password=reallyStrongPwd123;TrustServerCertificate=true;");
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S34_ConsoleApp_EfCore_Intro.Models;

namespace S34_ConsoleApp_EfCore_Intro
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB; Initial Catalog=MaktabSharif-104; Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Product> Products { get; set; }


    }
}

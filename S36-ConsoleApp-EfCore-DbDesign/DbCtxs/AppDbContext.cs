using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S36_ConsoleApp_EfCore_DbDesign.Entities;

namespace S36_ConsoleApp_EfCore_DbDesign.DbCtxs
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB; Initial Catalog=MaktabSharif-104-Blog; Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

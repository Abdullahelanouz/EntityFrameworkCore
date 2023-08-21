using Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
       
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-9SALBLK;Database=EFCore;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        DbSet<Blog> Blogs { get; set; }

       

    }
}

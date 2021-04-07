using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManager.Data
{
    public class BooksDbContext : DbContext
    {

        /// <summary>
        /// 注入口
        /// </summary>
        /// <param name="options"></param>
        public BooksDbContext(DbContextOptions<BooksDbContext> options) :base(options) {
        
        }


        public DbSet<Models.B_Users> Users{ get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.B_Users>().ToTable("B_Users");
       
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging();


        }

    }
}

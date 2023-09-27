using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    // Microsoft.EntityFrameworkCore + Tools + SqlServer
    // Microsoft.AspNetCore.Identity.EntityFrameworkCore
    // Microsoft.Extensions.Identity.Core

    public class MVCDbContext : IdentityDbContext<User>
    {
        public MVCDbContext()
        {

        }

        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=LAPTOP-AT94SBBO\\SQLEXPRESS;Database=MVCProjectTemplateDb;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Server=III-PC\\SQLEXPRESS;Database=MVCProjectTemplateDb;Trusted_Connection=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasOne(m => m.Sender).WithMany().HasForeignKey(m => m.SenderId);
            modelBuilder.Entity<Message>().HasOne(m => m.Receiver).WithMany().HasForeignKey(m => m.ReceiverId);
            modelBuilder.Entity<User>().HasMany(m => m.Messages).WithOne(m => m.Sender).HasForeignKey(m => m.SenderId).IsRequired(true);
            modelBuilder.Entity<User>().HasIndex(u => u.Name).IsUnique();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Hobby> Hobbies { get; set; }

    }
}

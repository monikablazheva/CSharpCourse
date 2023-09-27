using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //връзка с базата данни
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = ZooDB; Trusted_Connection = True");
        }
        // създаване на дб сетове
        public DbSet<Lion> Lions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Dolphin> Dolphins { get; set; }
        public DbSet<Monkey> Monkeys { get; set; }
    }
}

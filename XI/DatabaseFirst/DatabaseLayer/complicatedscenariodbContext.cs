using System;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseLayer
{
    public partial class complicatedscenariodbContext : DbContext
    {
        public complicatedscenariodbContext()
        {
        }

        public complicatedscenariodbContext(DbContextOptions<complicatedscenariodbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Port=3306;Database=complicatedscenariodb;Uid=root;Pwd=hophopapa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.HasIndex(e => e.RegionId, "fk_countries_regions");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(2)
                    .HasColumnName("country_id")
                    .IsFixedLength(true);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("country_name");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_countries_regions");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.CountryId, "fk_customers_coutries");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("decimal(6,0)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.Adress).HasColumnName("adress");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("country_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("last_name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk_customers_coutries");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.HasIndex(e => e.CountryId, "fk_departments_countries");

                entity.HasIndex(e => e.ManagerId, "fk_departments_employees");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(40)
                    .HasColumnName("adress");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("city");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("country_id")
                    .IsFixedLength(true);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("department_name");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .HasColumnName("postal_code");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .HasColumnName("state");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk_departments_countries");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_departments_employees");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => e.DepartmentId, "fk_employees_departments");

                entity.HasIndex(e => e.ManagerId, "fk_employees_employees");

                entity.HasIndex(e => e.JobId, "fk_employees_jobs");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("first_name");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("job_id");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("last_name");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(8,2)")
                    .HasColumnName("salary");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_employees_departments");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("fk_employees_jobs");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_employees_employees");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .HasColumnName("job_id");

                entity.Property(e => e.JobTotle)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasColumnName("job_totle");

                entity.Property(e => e.MaxSalary)
                    .HasColumnType("decimal(6,0)")
                    .HasColumnName("max_salary");

                entity.Property(e => e.MinSalary)
                    .HasColumnType("decimal(6,0)")
                    .HasColumnName("min_salary");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.HasIndex(e => e.CustomerId, "fk_orders_customers");

                entity.HasIndex(e => e.EmployeeId, "fk_orders_employees");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("decimal(6,0)")
                    .HasColumnName("customer_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ShipAdress)
                    .HasMaxLength(150)
                    .HasColumnName("ship_adress");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_orders_customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fk_orders_employees");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("order_items");

                entity.HasIndex(e => e.ProductId, "fk_order_items_products");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(8,0)")
                    .HasColumnName("quantity");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(8,2)")
                    .HasColumnName("unit_price");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("fk_order_items_orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_order_items_products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(2000)
                    .HasColumnName("descr");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(8,2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("product_name");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("region_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

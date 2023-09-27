using System;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer
{
    public partial class monikaairportContext : DbContext
    {
        public monikaairportContext()
        {
        }

        public monikaairportContext(DbContextOptions<monikaairportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1;Port=3306;Database=monikaairport;Uid=root;Pwd=hophopapa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("airports");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Income)
                    .HasColumnType("decimal(14,2)")
                    .HasColumnName("income");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("bookings");

                entity.HasIndex(e => e.AirportsId, "fk_bookings_airports");

                entity.HasIndex(e => e.FlightsId, "fk_bookings_flights");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirportsId).HasColumnName("airports_id");

                entity.Property(e => e.FlightsId).HasColumnName("flights_id");

                entity.Property(e => e.NumberOfPlaces).HasColumnName("number_of_places");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(9,2)")
                    .HasColumnName("price");

                entity.Property(e => e.TicketsCount).HasColumnName("tickets_count");

                entity.HasOne(d => d.Airports)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.AirportsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_bookings_airports");

                entity.HasOne(d => d.Flights)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.FlightsId)
                    .HasConstraintName("fk_bookings_flights");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("flights");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

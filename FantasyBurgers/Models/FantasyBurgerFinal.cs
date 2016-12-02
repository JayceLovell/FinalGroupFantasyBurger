namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgerFinal : DbContext
    {
        public FantasyBurgerFinal()
            : base("name=FantasyBurgerFinalConnectionString")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Burger> Burgers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Ordr> Ordrs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Appetizer>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Appetizer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appetizer>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Appetizer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Burger>()
                .Property(e => e.BurgerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Burger>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Burger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Burger>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Burger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.CartId)
                .IsUnicode(false);

            modelBuilder.Entity<Drink>()
                .Property(e => e.DrinkPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Drink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drink>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Drink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ordr>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ordr>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Ordr)
                .WillCascadeOnDelete(false);
        }
    }
}

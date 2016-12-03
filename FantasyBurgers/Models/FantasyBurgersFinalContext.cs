namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgersFinalContext : DbContext
    {
        public FantasyBurgersFinalContext()
            : base("name=FantasyBurgersFinalConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Burger> Burgers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Sides> Sides { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Appetizer>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Appetizer)
                .HasForeignKey(e => e.AppetizersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Appetizer>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Appetizer)
                .HasForeignKey(e => e.AppetizersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Burger>()
                .Property(e => e.BurgerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Burger>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Burger)
                .HasForeignKey(e => e.BurgersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Burger>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Burger)
                .HasForeignKey(e => e.BurgersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.CartId)
                .IsUnicode(false);

            modelBuilder.Entity<Drinks>()
                .Property(e => e.DrinkPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Drinks>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Drink)
                .HasForeignKey(e => e.DrinksId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Drinks>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Drink)
                .HasForeignKey(e => e.DrinksId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrdersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sides>()
                .Property(e => e.SidePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sides>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Side)
                .HasForeignKey(e => e.SidesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sides>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Side)
                .HasForeignKey(e => e.SidesId)
                .WillCascadeOnDelete(false);
        }
    }
}

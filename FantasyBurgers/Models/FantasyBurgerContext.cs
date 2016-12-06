namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgerContext : DbContext
    {
        public FantasyBurgerContext()
            : base("name=FantasyBurgerConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Burger> Burgers { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Side> Sides { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Burger>()
                .Property(e => e.BurgerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Drink>()
                .Property(e => e.DrinkPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Side>()
                .Property(e => e.SidePrice)
                .HasPrecision(10, 2);
        }
    }
}

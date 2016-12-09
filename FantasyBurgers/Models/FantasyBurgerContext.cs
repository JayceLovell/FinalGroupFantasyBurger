namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgerContext : DbContext
    {
        public FantasyBurgerContext()
            : base("name=FantasyBurgerConnectionString")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Burger> Burgers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Side> Sides { get; set; }

    }
}

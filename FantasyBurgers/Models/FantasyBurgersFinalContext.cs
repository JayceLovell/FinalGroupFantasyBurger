/*
 * This class represents the db context of our solution
 * Filename: FantasyBurgersFinalContext.cs
 * Modified date: 12/16/2016
 * Website: fantasyburgers.azurewebsites.net
 * Authors:
 *      - Eddie Song
 *      - Waynnel Lovelll
 *      - Thiago de Andrade
 *      - Sahil Mahajan
 *      - Anmol Sharma
 */
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

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}

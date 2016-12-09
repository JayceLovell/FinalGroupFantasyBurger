namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int AppetizersId { get; set; }

        public int BurgersId { get; set; }

        public int DrinksId { get; set; }

        public int SidesId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        public virtual Appetizer Appetizer { get; set; }

        public virtual Burger Burger { get; set; }

        public virtual Drink Drink { get; set; }

        public virtual Order Order { get; set; }

        public virtual Side Side { get; set; }
    }
}

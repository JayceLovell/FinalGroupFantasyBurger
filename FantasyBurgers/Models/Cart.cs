namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        [StringLength(50)]
        public string CartId { get; set; }

        public int AppetizersId { get; set; }

        public int BurgersId { get; set; }

        public int DrinksId { get; set; }

        public int SidesId { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual Appetizer Appetizer { get; set; }

        public virtual Burger Burger { get; set; }

        public virtual Drink Drink { get; set; }

        public virtual Side Side { get; set; }
    }
}

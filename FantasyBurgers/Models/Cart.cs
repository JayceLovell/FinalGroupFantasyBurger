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

<<<<<<< HEAD
        public int AppetizersId { get; set; }

        public int BurgersId { get; set; }

        public int DrinksId { get; set; }

        public int SidesId { get; set; }
=======
        public int AppetizerId { get; set; }

        public int BurgerId { get; set; }

        public int DrinkId { get; set; }
>>>>>>> refs/remotes/origin/master

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual Appetizer Appetizer { get; set; }

        public virtual Burger Burger { get; set; }

<<<<<<< HEAD
        public virtual Drinks Drink { get; set; }

        public virtual Sides Side { get; set; }
=======
        public virtual Drink Drink { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}

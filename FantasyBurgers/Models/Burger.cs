namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Burger
    {
        public int BurgerId { get; set; }

        [Required]
        public string BurgerName { get; set; }

        [Required]
        [StringLength(50)]
        public string BurgerShortDescription { get; set; }

        public string BurgerLongDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BurgerPrice { get; set; }

        public string BurgerImage { get; set; }
    }
}

namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drink
    {
        public int DrinkId { get; set; }

        [Column("Drink")]
        [Required]
        [Display(Name = "Name")]
        public string Drink1 { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Description")]
        public string DrinkShortDescription { get; set; }

        [Display(Name ="Detailed Description")]
        [ScaffoldColumn(false)]
        public string DrinkLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name ="Price")]
        public decimal DrinkPrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
        public string DrinkImage { get; set; }
    }
}

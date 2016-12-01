namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dessert
    {
        public int DessertId { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string DessertName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Description")]
        public string DessertShortDescription { get; set; }

        [Display(Name ="Detailed Description")]
        [ScaffoldColumn(false)]
        public string DessertLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name ="Price")]
        public decimal DessertPrice { get; set; }

        [Display(Name ="Display")]
        [ScaffoldColumn(false)]
        public string DessertImage { get; set; }
    }
}

namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Side
    {
        public int SideId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string SideName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string SideShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        [ScaffoldColumn(false)]
        public string SideLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal SidePrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
        public string SideImage { get; set; }
    }
}

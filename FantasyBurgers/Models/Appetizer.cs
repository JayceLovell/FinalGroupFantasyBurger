namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appetizer
    {
        public int AppetizerId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Name")]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Description")]
        public string AppetizerShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        [ScaffoldColumn(false)]
        public string AppetizerLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name ="Price")]
        public decimal AppetizerPrice { get; set; }

        [Display(Name ="Display")]
        [ScaffoldColumn(false)]
        public string AppetizerImage { get; set; }
    }
}

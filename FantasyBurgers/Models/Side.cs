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
        public string SideName { get; set; }

        [Required]
        [StringLength(50)]
        public string SideShortDescription { get; set; }

        public string SideLongDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SidePrice { get; set; }

        public string SideImage { get; set; }
    }
}

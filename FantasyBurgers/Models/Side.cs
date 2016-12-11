namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    /*Author's name: Waynell Lovell,
               Thiago De Andrade Souza,
               Edward Song,
               Sahil Mahajan,
               Anmol .
Date Created: November 30th, 2016
Version History: Part-1.Project Concept, Landing Page &	Site Security,
                 Part-2.Main Functionality & Database Connectivity,
                 Part-3.Finished Version – Fully Styled and Functional
File Description: Gets the Sides data from the database..  */
    public partial class Side : PurchasableItem {
        public int SideId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string SideName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string SideShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        public string SideLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal SidePrice { get; set; }

        [Display(Name = "Display")]
        public string SideImage { get; set; }

        public int getItemId() {
            return SideId;
        }

        public decimal getPrice() {
            return SidePrice;
        }

        public string getName() {
            return SideName;
        }
    }
}

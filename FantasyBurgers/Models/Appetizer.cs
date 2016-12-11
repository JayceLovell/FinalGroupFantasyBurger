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
    File Description: Gets the appetizer data from the database.  */
    public partial class Appetizer : PurchasableItem {

        public int AppetizerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string AppetizerShortDescription { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Detailed Description")]
        public string AppetizerLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal AppetizerPrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
        public string AppetizerImage { get; set; }

        public int getItemId() {
            return AppetizerId;
        }

        public decimal getPrice() {
            return AppetizerPrice;
        }

        public string getName() {
            return AppetizerName;
        }
    }
}

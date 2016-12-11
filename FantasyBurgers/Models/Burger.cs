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
File Description: Gets the burger data from the database.  */
    public partial class Burger : PurchasableItem {
        public int BurgerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string BurgerName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string BurgerShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        public string BurgerLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal BurgerPrice { get; set; }

        [Display(Name = "Display")]
        public string BurgerImage { get; set; }

        public int getItemId() {
            return BurgerId;
        }

        public decimal getPrice() {
            return BurgerPrice;
        }

        public string getName() {
            return BurgerName;
        }
    }
}
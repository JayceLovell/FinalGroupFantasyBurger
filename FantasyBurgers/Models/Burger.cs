namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
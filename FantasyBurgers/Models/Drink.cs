namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drink : PurchasableItem {
        public int DrinkId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string DrinkName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string DrinkShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        public string DrinkLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal DrinkPrice { get; set; }

        [Display(Name = "Display")]
        public string DrinkImage { get; set; }

        public int getItemId() {
            return DrinkId;
        }

        public decimal getPrice() {
            return DrinkPrice;
        }

        public string getName() {
            return DrinkName;
        }
    }
}

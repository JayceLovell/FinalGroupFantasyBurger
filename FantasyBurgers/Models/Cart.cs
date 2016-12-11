namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    /*Author's name: Waynell Lovell,
               Thiago De Andrade Souza,
               Edward Song,
               Sahil Mahajan,
               Anmol .
Date Created: November 30th, 2016
Version History: Part-1.Project Concept, Landing Page &	Site Security,
                 Part-2.Main Functionality & Database Connectivity,
                 Part-3.Finished Version – Fully Styled and Functional
File Description: Gets the cart data from the database.  */
    [Table("Cart")]
    public partial class Cart {
        [Key]
        public int RecordId { get; set; }

        [Required]
        [StringLength(50)]
        public string CartId { get; set; }

        [Required]
        public int PurchasableItemId { get; set; }

        [Required]
        public String PurchasableItemType { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }
    }

    public partial class Cart {

        private FantasyBurgerContext storeDB = new FantasyBurgerContext();

        public PurchasableItem getItem() {
            return storeDB.getItem(PurchasableItemType, PurchasableItemId);
        }
    }
}

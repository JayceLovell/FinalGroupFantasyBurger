namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

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

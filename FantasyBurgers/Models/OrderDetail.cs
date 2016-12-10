namespace FantasyBurgers.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("OrderDetail")]
    public partial class OrderDetail {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        [Required]
        public int PurchasableItemId { get; set; }

        [Required]
        public String PurchasableItemType { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }
    }

    public partial class OrderDetail {

        private FantasyBurgerContext storeDB = new FantasyBurgerContext();

        public PurchasableItem getItem() {
            return storeDB.getItem(PurchasableItemType, PurchasableItemId);
        }
    }
}

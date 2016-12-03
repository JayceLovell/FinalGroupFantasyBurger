namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appetizer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appetizer()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int AppetizerId { get; set; }

        [Required]
<<<<<<< HEAD
        [StringLength(50)]
        [Display(Name = "Name")]
=======
>>>>>>> refs/remotes/origin/master
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
<<<<<<< HEAD
        [Display(Name = "Description")]
=======
>>>>>>> refs/remotes/origin/master
        public string AppetizerShortDescription { get; set; }

        public string AppetizerLongDescription { get; set; }

        [Column(TypeName = "numeric")]
<<<<<<< HEAD
        [Display(Name = "Price")]
        public decimal AppetizerPrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
=======
        public decimal AppetizerPrice { get; set; }

>>>>>>> refs/remotes/origin/master
        public string AppetizerImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

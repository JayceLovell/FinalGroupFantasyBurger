/*
 * This class represents the model of menu
 * Filename: Menu.cs
 * Modified date: 12/16/2016
 * Website: fantasyburgers.azurewebsites.net
 * Authors:
 *      - Eddie Song
 *      - Waynnel Lovelll
 *      - Thiago de Andrade
 *      - Sahil Mahajan
 *      - Anmol Sharma
 */
namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public Menu()
        {

        }
        
        /// <summary>
        /// This constructor takes one argument name which sets teh title property to its value
        /// </summary>
        /// <param name="title"></param>
        public Menu(string title)
        {
            this.Name = title;
        }

        /*public Menu()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }*/

        public int MenuId { get; set; }

        public int Categoryid { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        [StringLength(160)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string ShortDescription { get; set; }

        [Display(Name = "Detailed Description")]
        public string LongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Display")]
        public string Image { get; set; }
        /*
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        */
    }
}

/*
 * This class represents the model of shopping cart
 * Filename: Cart.cs
 * Modified date: 12/16/2016
 * Authors:
 *      - Eddie Song
 *      - Waynnel Lovelll
 *      - Thiago de Andrade
 */
namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        public string CartId { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        public int Count { get; set; }

        public DateTime DateCreated { get; set; }

    }
}

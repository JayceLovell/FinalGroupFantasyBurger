/*
 * This class represents the model of order details
 * Filename: OrderDetail.cs
 * Modified date: 12/16/2016
 * Website: http://comp229-fantasy-burgers.azurewebsites.net/
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

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int MenuId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UnitPrice { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual Order Order { get; set; }
    }
}

/*
 * This class represents the model of food/drink category
 * Filename: Category.cs
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

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Menus = new HashSet<Menu>();
        }

        public int Categoryid { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(50)]
        [Display(Name = "Category")]
        public string Category1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}

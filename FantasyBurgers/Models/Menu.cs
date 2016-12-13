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

        /// <summary>
        /// This constructor takes one argument title which sets the itle property to its value
        /// </summary>
        /// <param name="title"></param>
        public Menu(string title)
        {
            this.Name = title;
        }
        [Key]
        public virtual int ItemId { get; set; }

        //Category foreign key
        public virtual int Categoryid { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        [StringLength(160)]
        [Display(Name="Name")]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name="Description")]
        public virtual string ShortDescription { get; set; }

        [Required]
        [Display(Name="Detailed Description")]
        public virtual string LongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name="Price")]
        public decimal Price { get; set; }

        [Display(Name="Display")]
        public string Image { get; set; }
    }
}

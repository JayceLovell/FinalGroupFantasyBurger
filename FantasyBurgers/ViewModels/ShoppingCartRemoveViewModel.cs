using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasyBurgers.Models;

/*
 * This class represents the model of an item being deleted
 * Filename: ShoppingCartRemoveViewModel.cs
 * Modified date: 12/16/2016
 * Website: http://comp229-fantasy-burgers.azurewebsites.net/
 * Authors:
 *		- Eddie Song
 *		- Waynnel Lovelll
 *		- Thiago de Andrade
 */
namespace FantasyBurgers.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
    }
}

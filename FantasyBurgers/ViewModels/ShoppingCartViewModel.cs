using FantasyBurgers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class represents the model of an item being listed
 * Filename: ShoppingCartViewModel.cs
 * Modified date: 12/16/2016
 * Website: http://comp229-fantasy-burgers.azurewebsites.net/
 * Authors:
 *		- Eddie Song
 *		- Waynnel Lovelll
 *		- Thiago de Andrade
 */
namespace FantasyBurgers.ViewModels
{
        public class ShoppingCartViewModel
        {
            public List<Cart> CartItems { get; set; }
            public decimal CartTotal { get; set; }
        }

}

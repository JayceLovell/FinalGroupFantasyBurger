using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Author's name: Waynell Lovell,
               Thiago De Andrade Souza,
               Edward Song,
               Sahil Mahajan,
               Anmol .
Date Created: November 30th, 2016
Version History: Part-1.Project Concept, Landing Page &	Site Security,
                 Part-2.Main Functionality & Database Connectivity,
                 Part-3.Finished Version – Fully Styled and Functional
File Description: Superclass - Purchasable item.  */
namespace FantasyBurgers.Models {
    public interface PurchasableItem {

        int getItemId();

        decimal getPrice();

        string getName();
    }
}

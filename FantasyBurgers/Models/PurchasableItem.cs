using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBurgers.Models {
    public interface PurchasableItem {

        int getItemId();

        decimal getPrice();

        string getName();
    }
}

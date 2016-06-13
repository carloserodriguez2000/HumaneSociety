using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Food
    {
        //private int price;      // Price is for each unit of measure. TotalCost = price*Units.
        //private int UOM;        // Units of measure. 
        public int level;      // How much there is in inventory
        //int proteinLevel;
        //int carbsLevel;
        //int sugarLevel;

        public void addAmount(int amount)
        {
            level += amount;
        }

        public void removeAmount(int amount)
        {
            if (level <= 0)
            {
                throw new System.NotImplementedException();
            }
            level -= amount;
        }
    } // END OF CLASS FOOD
} // END OF NAMESPACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class CatCage : Cage
    {
        private Cat aCat;
        //        public int cageStatus= 0; // 0 cage is empty, 1 cage is full

        void addCat(Cat dog)
        {
            aCat = dog;
        }

        void removeCat()
        {
            if( this.cageStatus == 0 )
            {
                // How to delete objects
            }
        }


    }
}
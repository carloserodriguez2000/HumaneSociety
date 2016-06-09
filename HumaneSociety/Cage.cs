using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Cage
    {
       public int cageID;
       public int cageStatus = 0; // 0 cage is empty, 1 cage is full

        public bool isCageEmpty()
        {
            if (cageStatus == 0)
                return true;
            else
                return false;
        }

        public bool isCageFull()
        {
            if (cageStatus == 1)
                return true;
            else
                return false;
        }

    }
}
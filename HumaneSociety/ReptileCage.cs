using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class ReptileCage : Cage
    {
        private Reptile aReptile;
        void addReptile(Reptile reptile)
        {
            aReptile = reptile;
        }

        void removeReptile()
        {
            if (this.cageStatus == 0)
            {
                // How to delete objects
            }
        }

 

    }
}
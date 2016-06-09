using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class BirdCage : Cage
    {
        private Bird aBird;
        void addBird(Bird bird)
        {
            aBird = bird;
        }

        void removeBird()
        {
            if (this.cageStatus == 0)
            {
                // How to delete objects
            }
        }

 
    }
}
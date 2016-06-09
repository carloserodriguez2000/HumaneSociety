using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class DogCage : Cage
    {
        private Dog aDog;
//        public int cageStatus= 0; // 0 cage is empty, 1 cage is full

        public void addDog(Dog dog)
        {
            aDog = dog;
        }

        public void removeDog()
        {
            if (this.cageStatus == 0)
            {
                // How to delete objects
            }
        }

 
    }
}
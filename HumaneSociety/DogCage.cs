using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class DogCage : Cage
    {
        private Dog aDog;
        public void addDog(Dog dog)
        {
            if (cageStatus == 1)
            {
                throw new System.NotImplementedException("adding with cageStatus == 1");
            }
            else
            {
                aDog = dog;
                cageStatus = 1; // cage has a dog.
            }
        }

        public Dog removeDog()
        {
            Dog theDogObj = null;

            if (cageStatus == 1)
            {
                // How to delete objects. Read in  web no such thing as delete in c#
                theDogObj = aDog;
                aDog = null;
                cageStatus = 0;
            }
            else
            {
                throw new System.NotImplementedException("removeDog with cageStatus == 0");
            }
            return theDogObj;
        }

    } // END OF CLASS
}// END OF NAMESPACE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Adopter
    {
       // private string Name;
       // private int Address;
        //private Application TheApplication;
 
        string getAnimalKind()
        {
            return "tiger";
        }
        public void FillApplication()
        {
            Application theApplication = new Application();
            theApplication.AnimalKind = getAnimalKind();
            saveApplication(theApplication);
            throw new System.NotImplementedException();
        }

        void saveApplication( Application theApplication)
        {
           // theApplicationApplication.name =
        }
        public void PayFee()
        {
            throw new System.NotImplementedException();
        }

    }
}
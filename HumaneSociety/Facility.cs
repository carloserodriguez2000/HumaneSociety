using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    class Facility
    {
        //public  Animals theAnimals;
        //private Supplies theSupplies;
        //public  Cages theCages;
        

        public Facility()
        {
            
        }
        public void Run()
        {
            Animals theAnimals = new Animals();
            Supplies theSupplies = new Supplies();
            Cages theCages = new Cages();
            char menuChoice;

            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
                                                    //"12345678901234567890123456789012"
                Console.WriteLine("Humane Society Management System");
                Console.WriteLine("1-) Manage Animals              ");
                Console.WriteLine("2-) Manage  Adopter             ");
                Console.WriteLine("3-) Show Animals                ");
                Console.WriteLine("4-) Manage Food Supplies        ");
                Console.WriteLine("5-) Manage Medication Supplies  ");
                Console.WriteLine("6-) Manage Cages                ");      // setup the cages available in the facility
                Console.WriteLine("7-)                             ");     
                Console.WriteLine("8-)                             ");     
                Console.WriteLine("9-) QUIT                        ");
                Console.Write(    "ENTER CHOICE:                   ");
                Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                menuChoice = Console.ReadKey().KeyChar;
                // or just pass 0,0

                switch (menuChoice)
                {
                    case '1':
                        theAnimals.manageAnimals(theSupplies, theCages);
                        break;
                    case '2':
                        Adopter theAdopter = new Adopter();
                        theAdopter.manageAdopter(theAnimals, theCages);
                       
                        break;
                    case '3':
                        theAnimals.showAnimals();
                        break;
                    case '4':
                        theSupplies.manageFoodSupplies();
                        break;
                    case '5':
                        //manageMedication();
                        break;
                    case '6':
                        theCages.manageCages();
                        break;
                    case '7':   
                    case '8':
                        Console.Beep(5000, 250);
                        Console.Beep(2000, 250);

                        break;
                    case '9':
                        letsQuit();
                        break;

                } 
            } while (menuChoice != '9');
        }

        private void letsQuit()
        {
               // throw new System.NotImplementedException();

        }
        //public void manageAnimals(List<Dog>, List<Cat> Cats, List<Bird> Birds, List<Reptile>)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
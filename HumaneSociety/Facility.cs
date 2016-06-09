using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    class Facility
    {
        private Animals theAnimals;
        private Supplies theSupplies;
        private Cages theCages;

        public Facility()
        {
            
        }
        public void Run()
        {
            theAnimals = new Animals();
            theSupplies = new Supplies();
            theCages = new Cages();
            char menuChoice;

            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
                                                    //"12345678901234567890123456789012"
                Console.WriteLine("Humane Society Management System");
                Console.WriteLine("1-) Manage Animals              ");
                Console.WriteLine("2-) Manage Donor                ");
                Console.WriteLine("3-) Show Animals                ");
                Console.WriteLine("4-) Manage Food Supplies        ");
                Console.WriteLine("5-) Manage Medication Supplies  ");
                Console.WriteLine("6-) Manage Cages                ");      // setup the cages available in the facility
                Console.WriteLine("9-) QUIT                        ");
                Console.Write("ENTER CHOICE:                   ");
                Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                menuChoice = Console.ReadKey().KeyChar;
                // or just pass 0,0
                switch (menuChoice)
                {
                    case '1':
                        theAnimals.manageAnimals(theSupplies, theCages);
                        break;
                    case '2':
                        Donor Donor = new Donor();
                        Donor.manageDonor();
                        break;
                    case '3':
                        theAnimals.showAnimals();
                        break;
                    case '4':
                        theSupplies.manageFoodSupplies();
                        break;
                    case '5':
                        theSupplies.manageMedicationSupplies();
                        break;
                    case '6':
                        theCages.manageCages();
                        break;
                    case '9':
                        letsQuit();
                        break;

                } 
            } while (menuChoice != '9');
        }

        private void letsQuit()
        {
                throw new System.NotImplementedException();

        }
        //public void manageAnimals(List<Dog>, List<Cat> Cats, List<Bird> Birds, List<Reptile>)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
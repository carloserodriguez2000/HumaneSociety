using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
     class Supplies
    {
        private int Collars;
        private int Leash;
        private int Box;
        public  CatFood catFood;
        public DogFood dogFood;
        public BirdFood birdFood;
        public ReptileFood reptileFood;

        public  Supplies()
        {
            catFood = new CatFood();
            dogFood = new DogFood();
            birdFood = new BirdFood();
            reptileFood = new ReptileFood();
        }


        public void manageFoodSupplies()
        {
            char menuChoice;
            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
                //                "12345678901234567890123456789012" 
                Console.WriteLine("MANAGE SUPPLIES                 ");
                Console.WriteLine("1-) Add Dog Food.               ");
                Console.WriteLine("2-) Add Cat Food                ");
                Console.WriteLine("3-) Add Bird Food               ");
                Console.WriteLine("4-) Add Reptile Food            ");
                Console.WriteLine("5-) Show Food Inventory         ");
                Console.WriteLine("6-) Add Reptile Food            ");
                Console.WriteLine("7-) RETURN TO MAIN MENU         ");
                Console.Write("ENTER CHOICE:                   ");
                Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
                menuChoice = Console.ReadKey().KeyChar;

                switch (menuChoice)
                {
                    case '1':
                        dogFood.addAmount(askAmount("Dog Food"));
                        break;
                    case '2':
                        catFood.addAmount(askAmount("Cat Food"));
                        break;
                    case '3':
                        birdFood.addAmount(askAmount("Bird Food"));
                        break;
                    case '4':
                        reptileFood.addAmount(askAmount("Reptile Food"));
                        break;
                    case '5':
                        showFood();
                        break;
                    case '9':
                        cleanUpBack();
                        Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.

                        break;
                }

            } while (menuChoice != '9');
        }

        private int askAmount(string animalType)
        {
            int len;
            string msg = "Enter Amount of {0}: ";
            
            Console.Write(msg, animalType);
            int amount = Console.Read();
            Console.SetCursorPosition(Console.CursorLeft - msg.Length, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
            Console.Write("                       ");

            return amount;
        }
        private void showFood()
        {
            Console.WriteLine("Current Food Inventory: ");
            Console.WriteLine("We have %s of Dog Food in inventory", dogFood.level.ToString()); 
            Console.WriteLine("We have %s of Cat Food in inventory", catFood.level.ToString()); 
            Console.WriteLine("We have %s of Bird Food in inventory", birdFood.level.ToString());
            Console.WriteLine("We have %s of Reptile Food in inventory", reptileFood.level.ToString());

            throw new System.NotImplementedException();
        }

        private void cleanUpBack()
        {

        }
        

        public void manageMedicationSupplies()
        {
            Console.WriteLine("MANAGE SUPPLIES");
            Console.WriteLine("1-) Manage Dog Medication.");
            Console.WriteLine("2-) Manage Cat Medication.");
            Console.WriteLine("3-) Manage Bird Medication.");
            Console.WriteLine("4-) Manage Reptile Medication.");
            Console.WriteLine("5-) Show Medication Inventory");
            Console.WriteLine("6-) RETURN TO MAIN MENU");


            char menuChoice = Console.ReadKey().KeyChar;
            switch (menuChoice)
            {
                case '1':
                    addDogMedication();
                    break;
                case '2':
                    addCatMedication();
                    break;
                case '3':
                    addBirdMedication();
                    break;
                case '4':
                    addReptileMedication();
                    break;
                case '5':
                    showMedicationInventory();
                    break;
                case '6':
                    quitCleanupMedication();
                    break;
            }
        }
        public void addDogMedication()
        {

        }

        public void addCatMedication()
        {

        }

        public void addBirdMedication()
        {

        }

        public void addReptileMedication()
        {

        }
        public void showMedicationInventory()
        {

        }

        public void quitCleanupMedication()
        {

        }
    }
}
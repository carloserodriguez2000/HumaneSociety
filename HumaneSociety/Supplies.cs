using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Supplies
    {
        //private int Collars;
        //private int Leash;
        //private int Box;
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
                Console.WriteLine("    MANAGE SUPPLIES             ");
                Console.WriteLine("1-) Add Dog Food.               ");
                Console.WriteLine("2-) Add Cat Food                ");
                Console.WriteLine("3-) Add Bird Food               ");
                Console.WriteLine("4-) Add Reptile Food            ");
                Console.WriteLine("5-) Show Food Inventory         ");
                Console.WriteLine("6-) Add Reptile Food            ");
                Console.WriteLine("9-) RETURN TO MAIN MENU         ");
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

                        break;
                }

            } while (menuChoice != '9');
        } //

        private int askAmount(string animalType)
        {
            string msg = "Enter Amount of {0}: ";
            
            int currLeftPos = Console.CursorLeft;
            Console.Write(msg, animalType);
            int amount = Convert.ToUInt16(Console.ReadLine());
            Console.SetCursorPosition(currLeftPos, Console.CursorTop -1);    // move the cursor up Nine lines to paint next menu on top.
            Console.Write("                       ");

            return amount;
        }
        private void showFood()
        {
            int currYPosition = Console.CursorTop;
            Console.WriteLine("Current Food Inventory: ");
            Console.WriteLine("We have {0} of Dog Food in inventory", dogFood.level.ToString()); 
            Console.WriteLine("We have {0} of Cat Food in inventory", catFood.level.ToString()); 
            Console.WriteLine("We have {0} of Bird Food in inventory", birdFood.level.ToString());
            Console.WriteLine("We have {0} of Reptile Food in inventory", reptileFood.level.ToString());
            Console.Write(" Press any key to continue");
            Console.ReadKey(true);
            Console.SetCursorPosition(0, currYPosition - 1);
            for( int i = 0; i<6; i++)
            {
                //                "12345678901234567890123456789012" 
                Console.WriteLine("                                "); // Erase the lines above before returing to menu

            }
            //throw new System.NotImplementedException();
        }

        private void cleanUpBack()
        {

        }
        

 
    }
}
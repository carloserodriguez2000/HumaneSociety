using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Animals
    {
        private List<Dog> Dogs;
        private List<Cat> Cats;
        private List<Bird> Birds;
        private List<Reptile> Reptiles;

        public Animals()
        {
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
            Birds = new List<Bird>();
            Reptiles = new List<Reptile>();

        }
        public void manageAnimals(Supplies theSupplies, Cages theCages)
        {
            char menuChoice;
            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.

                //                "12345678901234567890123456789012" 
                Console.WriteLine("MANAGE ANIMALS                  ");
                Console.WriteLine("1-) Feed Dogs                   ");
                Console.WriteLine("2-) Feed Cats                   ");
                Console.WriteLine("3-) Feed Birds                  ");
                Console.WriteLine("4-) Feed Reptiles               ");
                Console.WriteLine("5-) Add Dog                     ");
                Console.WriteLine("6-) Add Cat                     ");
                Console.WriteLine("7-) Add Bird                    ");
                Console.WriteLine("8-) Add Reptile                 ");
                Console.WriteLine("9-) BACK TO MAIN MENU           ");
                Console.Write("ENTER CHOICE:                       ");
                Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                menuChoice = Console.ReadKey().KeyChar;
                // or just pass 0,0
                switch (menuChoice)
                {
                    case '1':
                        feedDogs(theSupplies.dogFood);
                        break;
                    case '2':
                        feedCats(theSupplies.catFood);
                        break;
                    case '3':
                        feedBirds(theSupplies.birdFood);
                        break;
                    case '4':
                        feedReptiles(theSupplies.reptileFood);
                        break;
                    case '5':
                        addDog(theCages.getDogCage());
                        break;
                    case '6':
                        addCat();
                        break;
                    case '7':
                        addBird();
                        break;
                    case '8':
                        addReptile();
                        break;
                    case '9':
                        cleanUpBack();
                        break;
                }

            } while (menuChoice != '9');

            return;
        }

        private void feedCats(CatFood theCatFood)
        {
            // TODO: Add functionality to check if feeding is on schedule to prevent overfeeding
            if (theCatFood.level <= 0)
            {
                Console.Write("Sorry. Out of Cat Food. Press any key to continue");
                Console.ReadKey(true);
                //throw new System.NotImplementedException("Cat Food is empty");
                return;
            }
            if (Cats.Count <= 0)
            {
                Console.Write("Sorry. No Cats to Feed. Press any key to continue");
                Console.ReadKey(true);
                //throw new System.NotImplementedException("No Cats to Feed");
                return;
            }

            foreach (var cat in Cats)
            {
                cat.feedIt(cat.FeedingAmount);
                theCatFood.level -= cat.FeedingAmount;
            }
        }
        private void feedDogs(DogFood theDogFood)
        {
            int currLeftPos = Console.CursorLeft;
            Console.SetCursorPosition(currLeftPos - 1, Console.CursorTop);
            if (theDogFood.level <= 0)
            {
                string msg = "Sorry. Out of Dog Food. Press any key to continue";
                int currxPos = Console.CursorLeft;
                int curryPOs = Console.CursorTop;
                Console.Write(msg );
                Console.ReadKey(true);
                Console.SetCursorPosition(currxPos-1, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                Console.Write("                                                  ");    // to erase the last message

                //throw new System.NotImplementedException("Dog Food is empty");
                return;
            }
            if (Dogs == null)
            {
                Console.Write("Sorry. No Dogs to Feed. Press any key to continue");
                Console.ReadKey(true);
                //throw new System.NotImplementedException("No Dogs to Feed");
                return;
            }
            foreach (var dog in Dogs)
            {
                dog.feedIt(dog.FeedingAmount);
                theDogFood.level -= dog.FeedingAmount;
            }

            return;
        }
        private void feedBirds(BirdFood theBirdFood)
        {
            foreach (var bird in Birds)
            {
                bird.feedIt(bird.FeedingAmount);
                theBirdFood.level -= bird.FeedingAmount;
            }

            throw new System.NotImplementedException();

        }
        private void feedReptiles(ReptileFood theReptileFood)
        {
            foreach (var reptile in Reptiles)
            {
                reptile.feedIt(reptile.FeedingAmount);
                theReptileFood.level -= reptile.FeedingAmount;
            }
            throw new System.NotImplementedException();

        }
        private void addDog(DogCage aCage)
        {
            if (aCage == null)
            {
                return;
               // throw new System.NotImplementedException("addDog no cages null");
            }

            Dog aDog = new Dog();
            Console.Write("Enter new dog's name: ");
            string name = Console.ReadLine();
            aDog.Name = name;
            aDog.cageID = aCage.cageID;
            aCage.addDog(aDog);
            Dogs.Add(aDog);

        }
        public void removeDog(int cageID, Cages theCages)
        {
            Dog theDog = null;

            if (cageID == 0)
            {
                throw new System.NotImplementedException("remove Dog no valid cageID");
            }

            DogCage theDogCage = theCages.getThisDogCage(cageID);
            theDogCage.cageStatus = 0;          //set cage to empty so it can be used by another pet.
            theDog = theDogCage.removeDog();    // remove the Dog object reference from the cage object.
            Console.WriteLine("Dog {0} is in Cage {1}", theDog.Name, theDog.cageID);
            theDog.adopted = true;
            Dogs.Remove(theDog);                // remove the Dog object from the list of Dogs

        }

        public void removeCat(int cageID, Cages theCages)
        {

        }
        public void removeBird(int cageID, Cages theCages)
        {

        }


        private void addCat()
        {
            Cat aCat = new Cat();
            Console.Write("Enter new Cats's name: ");
            string name = Console.ReadLine();
            aCat.Name = name;
            Cats.Add(aCat);
            throw new System.NotImplementedException();

        }
        private void addBird()
        {
            Bird aBird = new Bird();
            Console.Write("Enter new Birds's name: ");
            string name = Console.ReadLine();
            aBird.Name = name;
            Birds.Add(aBird);

            throw new System.NotImplementedException();

        }
        private void addReptile()
        {
            Reptile aReptile = new Reptile();
            Console.Write("Enter new Reptile's name: ");
            string name = Console.ReadLine();
            aReptile.Name = name;
            Reptiles.Add(aReptile);
            throw new System.NotImplementedException();

        }
        private void cleanUpBack()
        {
            //throw new System.NotImplementedException();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 11; i++)
            {
                //                "12345678901234567890123456789012" 
                Console.WriteLine("                                "); // Erase the lines above before returing to menu
            }
        }

        public void showDogs()
        {
            int currYPos;

            currYPos = Console.CursorTop;

            foreach (Dog dog in Dogs)
            {
                Console.WriteLine("Dog {0} is in Cage {1}", dog.Name, dog.cageID);
            }
        }
        public void showCats()
        {
            int currYPos;

            currYPos = Console.CursorTop;
            foreach (Cat cat in Cats)
            { Console.WriteLine("Cat {0} is in Cage {1}", cat.Name, cat.cageID); }
        }
        public void showBirds()
        {
            int currYPos;

            currYPos = Console.CursorTop;
            foreach (Bird bird in Birds)
            { Console.WriteLine("Bird {0} is in Cage {1}", bird.Name, bird.cageID); }
        }
        public void showAnimals()
        {
            int currYPos;

            currYPos = Console.CursorTop;

            foreach (Dog dog in Dogs)
            { Console.WriteLine("Dog {0} is in Cage {1}", dog.Name, dog.cageID); }

            foreach (Cat cat in Cats)
            { Console.WriteLine("Cat {0} is in Cage {1}", cat.Name, cat.cageID); }

            foreach (Bird bird in Birds)
            { Console.WriteLine("Bird {0} is in Cage {1}", bird.Name, bird.cageID); }

            foreach (Reptile reptile in Reptiles)
            { Console.WriteLine("Reptile {0} is in Cage {1}", reptile.Name, reptile.cageID); }

            Console.Write("Hit any key to continue");
            Console.Read();
            Console.SetCursorPosition(0, currYPos);
            for (int i = 0; i < 11; i++)
            {
                //                "12345678901234567890123456789012" 
                Console.WriteLine("                                "); // Erase the lines above before returing to menu
            }
        }

    } // END OF CLASS ANIMAL
} // END OF NAMESPACE
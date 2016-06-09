using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    class Animals
    {
        private List<Dog> Dogs;
        private List<Cat> Cats;
        private List<Bird> Birds;
        private List<Reptile> Reptiles;

        public Animals()
        {

        }
        public void manageAnimals(Supplies theSupplies, Cages theCages)
        {
            char menuChoice;
            do
            {
                // Console.SetCursorPosition(0, Console.CursorTop-5);
                //                 "12345678901234567890123456789012" 
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
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
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
                throw new System.NotImplementedException("Cat Food is empty");
                return;
            }
            if (Cats.Count <= 0)
            {
                throw new System.NotImplementedException("No Cats to Feed");
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
            if (theDogFood.level <= 0)
            {
                throw new System.NotImplementedException("Dog Food is empty");
                return;
            }
            if (Dogs == null )
            {
                throw new System.NotImplementedException("No Dogs to Feed");
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
            Dog aDog = new Dog();
            Console.Write("Enter new dog's name: ");
            string name = Console.ReadLine();
            aDog.Name = name;
            Dogs.Add(aDog);

            if (aCage == null)
            {
                throw new System.NotImplementedException();
            }

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
            throw new System.NotImplementedException();

        }
        public void showAnimals()
        {

            foreach (Dog dog in Dogs)
            { Console.WriteLine("Dog %s is in Cage %s", dog.Name); }

            foreach (Cat cat in Cats)
            { Console.WriteLine("Cat %s is in Cage %s", cat.Name); }

            foreach (Bird bird in Birds)
            { Console.WriteLine("Bird %s is in Cage %s", bird.Name); }

            foreach (Reptile reptile in Reptiles)
            { Console.WriteLine("Reptile %s is in Cage %s", reptile.Name); }

            throw new System.NotImplementedException();

        }

    }
}
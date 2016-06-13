using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Adopter
    {
        //private string Name;
        //private int Address;
        private Application theApplication;


        public Adopter()
        {
            theApplication = new Application();
        }

        public void manageAdopter(Animals theAnimals, Cages theCages)
        {
            char menuChoice;

            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
                                                    //"12345678901234567890123456789012"
                Console.WriteLine("    MANAGE ADOPTER              ");
                Console.WriteLine("1-) Fill Aplication             ");
                Console.WriteLine("2-) Pay Fee                     ");
                Console.WriteLine("3-) Select Pet                  ");
                Console.WriteLine("4-)                             ");
                Console.WriteLine("5-)                             ");
                Console.WriteLine("6-)                             ");      // setup the cages available in the facility
                Console.WriteLine("9-) QUIT                        ");
                Console.Write("ENTER CHOICE:                   ");
                Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                menuChoice = Console.ReadKey().KeyChar;
                switch (menuChoice)
                {
                    case '1':
                        fillApplication();
                        break;
                    case '2':
                        payFee();
                        break;
                    case '3':
                        selectPet(theAnimals, theCages);
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '9':
                        cleanUpBack();
                        break;

                }
            } while (menuChoice != '9');
        }

        private int selectDog(Animals theAnimals)
        {
            Console.WriteLine("Please enter ID of desired Dog: ");
            theAnimals.showDogs();
            int cageID = Convert.ToUInt16(Console.ReadLine());
            return cageID;
        }
        private int selectCat(Animals theAnimals)
        {
            Console.WriteLine("Please enter ID of desired Cat: ");
            theAnimals.showCats();
            int cageID = Convert.ToUInt16(Console.ReadLine());
            return cageID;
        }
        private int selectBird(Animals theAnimals)
        {
            Console.WriteLine("Please enter ID of desired Bird: ");
            theAnimals.showBirds();
            int cageID = Convert.ToUInt16(Console.ReadLine());
            return cageID;
        }
        private void selectPet(Animals theAnimals, Cages theCages)
        {
            int cageID;

            if (this.theApplication.AnimalKind == "DOG")
            {
                cageID = selectDog(theAnimals);
                theAnimals.removeDog(cageID, theCages);

            }
            if (this.theApplication.AnimalKind == "CAT")
            {
                cageID = selectCat(theAnimals);
                theAnimals.removeCat(cageID, theCages);

            }
            if (this.theApplication.AnimalKind == "BIRD")
            {
                cageID = selectBird(theAnimals);
                theAnimals.removeBird(cageID, theCages);

            }
        }
        private string getAnimalKind()
        {
            string[] animalKinds = { "DOG", "CAT", "BIRD", "REPTILE" };
            string animalDesired;

            do
            {
                Console.Write("Please enter desired animal kind (Dog,Cat,Bird,Reptile");
                animalDesired = Console.ReadLine().ToUpper();
            } while (animalKinds.Contains(animalDesired) == false);
            return animalDesired;
        }

        private string getResidenceType()
        {
            string[] residenceKinds = { "HOUSE", "APARTMENT", "CONDO" };
            string adopterResidence;

            do
            {
                Console.Write("Please enter your type of residence (House,Apartment,Condo");
                adopterResidence = Console.ReadLine().ToUpper();
            } while (residenceKinds.Contains(adopterResidence) == false);
            return adopterResidence;
        }
        private string getOtherPetsStatus()
        {
            string[] adopterAnswer = { "YES", "NO" };
            string adopterOtherPets;

            do
            {
                Console.Write("Do You have other Pets?:  Yes/No");
                adopterOtherPets = Console.ReadLine().ToUpper();
            } while (adopterAnswer.Contains(adopterOtherPets) == false);
            return adopterOtherPets;
        }
        private string getAdopterName()
        {
            Console.Write("Please enter your name:");
            string adopterName = Console.ReadLine().ToUpper();
            return adopterName;
        }
        private void fillApplication()
        {
            theApplication.adopterName = getAdopterName();
            theApplication.AnimalKind = getAnimalKind();
            theApplication.ResidenceType = getResidenceType();
            theApplication.HasPets = getOtherPetsStatus();

            saveApplication(theApplication);
            throw new System.NotImplementedException();
        }

        void saveApplication(Application theApplication)
        {
            // theApplicationApplication.name =
        }
        public void payFee()
        {
            throw new System.NotImplementedException();
        }

        private void cleanUpBack()
        {

        }
    }
}
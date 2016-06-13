using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{

    public class Cages
    {
        int lastCageID = 0;     // used to give unique ID's to each cage
        private List<DogCage> dogCages;
        private List<CatCage> catCages;
        private List<BirdCage> birdCages;
        private List<ReptileCage> reptileCages;

        public Cages()
        {
            dogCages = new List<DogCage>();
            catCages = new List<CatCage>() ;
            birdCages = new List< BirdCage>() ;
            reptileCages = new List<ReptileCage>() ;
    }

        public void manageCages()
        {
            char menuChoice;
            do
            {
                Console.SetCursorPosition(0, 0);    // move the cursor up Nine lines to paint next menu on top.
                //                "12345678901234567890123456789012" 
                Console.WriteLine("   MANAGE CAGES                 ");
                Console.WriteLine("1-) Add Dog     Cages           ");
                Console.WriteLine("2-) Add Cat     Cages           ");
                Console.WriteLine("3-) Add Bird    Cages           ");
                Console.WriteLine("4-) Add Reptile Cages           ");
                Console.WriteLine("5-) Delete Dog     Cages        ");
                Console.WriteLine("6-) Delete Cat     Cages        ");      // setup the cages available in the facility
                Console.WriteLine("7-) Delete Bird    Cages        ");      // setup the cages available in the facility
                Console.WriteLine("8-) Delete Reptile Cages        ");      // setup the cages available in the facility
                Console.WriteLine("9-) BACK TO MAIN MENU");
                Console.Write    ("                                  ");
                Console.SetCursorPosition(0, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                Console.Write("ENTER CHOICE: ");
                menuChoice = Console.ReadKey().KeyChar;

                switch (menuChoice)
                {
                    case '1':
                        createDogCages();
                        break;
                    case '2':
                        createCatCages();
                        break;
                    case '3':
                        createBirdCages();
                        break;
                    case '4':
                        createReptileCages();
                        break;
                    case '5':
                        deleteDogCage();
                        break;
                    case '6':
                        deleteCatCage();
                        break;
                    case '7':
                        deleteBirdCage();
                        break;
                    case '8':
                        deleteReptileCage();
                        break;
                    case '9':
                        cleanUpBack();
                        break;
                }

            } while (menuChoice != '9');

        }

        //private int askAmount(string animalType)
        //{
        //    Console.Write("Enter Amount of %s Cages: ", animalType);
        //    int amount = Console.Read();
        //    return amount;
        //}
        void createDogCages()
        {
            DogCage newCage = new DogCage();
            newCage.cageID = (++lastCageID);
            dogCages.Add(newCage);
            Console.WriteLine(" ");
            Console.WriteLine("One Dog Cage Added. Total Dog Cages = {0}", dogCages.Count);
        }
        void createCatCages()
        {
            CatCage newCage = new CatCage();
            newCage.cageID = (++lastCageID);
            catCages.Add(newCage);
            Console.WriteLine(" ");
            Console.WriteLine("One Cat Cage Added. Total Cat Cages = {0}", catCages.Count);
        }
        

        void createBirdCages()
        {
            BirdCage newCage = new BirdCage();
            newCage.cageID = (++lastCageID);
            birdCages.Add(newCage);
            Console.WriteLine(" ");
            Console.WriteLine("One Bird Cage Added. Total Bird Cages = {0}", birdCages.Count);
        }

        void createReptileCages()
        {
            ReptileCage newCage = new ReptileCage();
            newCage.cageID = (++lastCageID);
            reptileCages.Add(newCage);
            Console.WriteLine(" ");
            Console.WriteLine("One Retile Cage Added. Total Reptile Cages = {0}", reptileCages.Count);
        }

        private int getCageID()
        {
            Console.Write("Enter Cage ID");
            int cageID = Convert.ToUInt16( Console.Read());
            return cageID;
        }
        void deleteDogCage()
        {
            Console.Write("Enter Cage ID");
            int cageID = getCageID();

            //dogCages.Find(x => x.cageID == cageID);
            foreach (var dogCage in dogCages)  // Find a dog cage to delete
            {
                if (dogCage.cageID == cageID)
                {
                    if (dogCage.cageStatus == 0)
                    {
                        dogCages.Remove(dogCage);
                    }
                    else
                    {
                        string msg = "Sorry. Dog Cage Is not empty. Press any key to continue";
                        int currxPos = Console.CursorLeft;
                        int curryPOs = Console.CursorTop;
                        Console.Write(msg);
                        Console.ReadKey(true);
                        Console.SetCursorPosition(currxPos - 1, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                        Console.Write("                                                                 ");
                        //throw new System.IndexOutOfRangeException("deleteDogCage NOT EMPTY");
                    }
                }
            }
        }
        void deleteCatCage()
        {
            int cageID = getCageID();

           //catCages.Find(x => x.cageID == cageID);
            foreach (var catCage in catCages)  // Find a cat cage to delete
            {
                if (catCage.cageID == cageID)
                {
                    if (catCage.cageStatus == 0)
                    {
                        catCages.Remove(catCage);
                    }
                    else
                    {
                        throw new System.IndexOutOfRangeException("deletecatCage NOT EMPTY");
                    }
                }
                else
                {
                    throw new System.IndexOutOfRangeException("deletecatCage cageID not found");
                }
            }
        }
        void deleteBirdCage()
        {
            int cageID = getCageID();

            //birdCages.Find(x => x.cageID == cageID);
            foreach (var birdCage in birdCages)  // Find a bird cage to delete
            {
                if (birdCage.cageID == cageID)
                {
                    if (birdCage.cageStatus == 0)
                    {
                        birdCages.Remove(birdCage);
                    }
                    else
                    {
                        throw new System.IndexOutOfRangeException("deletebirdCage NOT EMPTY");
                    }
                }
                else
                {
                    throw new System.IndexOutOfRangeException("deletebirdCage cageID not found");

                }
            }
        }
        void deleteReptileCage()
        {
            int cageID = getCageID();

            //reptileCages.Find(x => x.cageID == cageID);
            foreach (var reptileCage in reptileCages)  // Find a reptile cage to delete
            {
                if (reptileCage.cageID == cageID)
                {
                    if (reptileCage.cageStatus == 0)
                    {
                        reptileCages.Remove(reptileCage);
                    }
                    else
                    {
                        throw new System.IndexOutOfRangeException("deletereptileCage NOT EMPTY");
                    }
                }
                else
                {
                    throw new System.IndexOutOfRangeException("deletereptileCage cageID not found");

                }
            }
        }

        public DogCage getDogCage()
        {
            DogCage adogCage = null;
       
            foreach (var aCage in dogCages)
            {
                if (aCage.isCageEmpty())
                {
                    adogCage = aCage;
                    break;
                }
            }
            if (adogCage == null)
            {
                int currxPos = Console.CursorLeft;
                Console.Write("Sorry. No open cages at this time. Hit a key to continue.");
                Console.ReadKey();
                Console.SetCursorPosition(currxPos - 1, Console.CursorTop);    // move the cursor up Nine lines to paint next menu on top.
                Console.Write("                                                            ");    // to erase the last message
            }
            return (adogCage);
        }
        public DogCage getThisDogCage(int cageID)
        {
            DogCage adogCage = null;

            foreach (DogCage aCage in dogCages)
            {
                if( aCage.cageID == cageID)
                {
                    adogCage = aCage;
                }
            }

                return adogCage;

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

    }// END OF Class Cages

}// END OF namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Animal
    {
        public string Name;
        public int FeedingAmount;
        public DateTime timeFeed;
        public String breed;
        public int cageID;
        public bool adopted;    // True == adpopted False == available for adoption


        public List<Inmunization> inmunizations;
        //private int Weight;               // implement later
        //private int Health;
        //private int FeedingFrequency;
        
        void animal()
        {
            adopted = false;
            cageID = 0;
        }

        public void feedIt(int amount)
        {

        }

        public void giveInmunization()
        {
            

        }

    }
}
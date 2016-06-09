using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class Donor
    {
        public void manageDonor()
        {
            Console.Write("Hello Donor. What is your name?;");
            string donorName = (string)Console.ReadLine();

            Console.Write("Hello Donor. How much wold you like to give?;");
            int donation = (int)Console.Read();
            saveDonation(donorName, donation);

     
            throw new System.NotImplementedException();
        }
        void saveDonation(string name, int amount)
        {
            // File I/O Donation saving
        }
    }
}
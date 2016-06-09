using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static  string[,] DogsTable = new string[20, 10];     // 20 rows, 10 columns

        static List<string> DogsTableList = new List<string>();

        static void ReadStrArrayCSV()
        {
            string[] lines = System.IO.File.ReadAllLines(@"dogsTable.csv");
            string linee = lines[0];
            lines.CopyTo(DogsTable, 0);

            string[] elements = linee.Split(',');
            if (elements.Count() == 3)                          // must have 3 elements in a row.
            {

            }
        }

        static void  ReadTableCSV()
        {

        }
        static void WriteTableCSV()
        {

            ReadTableCSV();
            int newDogID = DogsTableList.Count() +1;

            string newDog;
            int age=6;
            string breed = "German Sheperd";

            newDog= (newDogID.ToString() + "Max" + age.ToString() + breed);

            

          //  System.IO.File.WriteAllLines(@"dogsTable.csv",DogsTable);



        }
        static void Main(string[] args)
        {
            Facility HumaneFacility = new Facility();
            HumaneFacility.Run();

       //     string[] elements = lines.split( linee, ',');

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDocumentsManagementSystem
{
    class STUDENTS //student list
    {
        public static void studentList()
        {

            List<string> studName = new List<string>();
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|-------------------------- STUDENT LIST --------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            studName.Add("Angeliko Roland Centeno");
            studName.Add("John Patrick Macalalad");
            studName.Add("James Darrel Advincula");
            studName.Add("Nestor Gerona");
            studName.Add("Josel Catalan");
            studName.Add("John Edward Barreras");
            studName.Add("Kristian Paul Enore");

            foreach (string name in studName)
            {

                Console.WriteLine(name);

            }
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("        PLEASE ENTER STUDENT NAME FROM THE 'STUDENT LIST'           ");
            Console.WriteLine("|------------------------------------------------------------------|");
            string inputName = Console.ReadLine();


            if (inputName == (""))
            {
                Console.WriteLine("PLEASE SELECT A STUDENT");
            }
            else if (studName.Any(s => s.Equals(inputName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("|------------------------------------------------------------------|");

                Console.WriteLine("--  " + inputName +"  --" +   "\n ------ HAS NO RECENT FILES ------");

                INTERFACE.interFace();
            }
            else
            {
                Console.WriteLine("STUDENT NOT FOUND");

            }

        }

        public static void exit()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|---------------- The program is now Shutting down ----------------|");
            Console.WriteLine("|------------------------ Have a nice Day -------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            System.Environment.Exit(0);
        }
    }
}


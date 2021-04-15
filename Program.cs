using System;

namespace StudentDocumentsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter username: ");
            string uName = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pWord = Console.ReadLine();

            string studName1 = "angeliko centeno";
            string studName2 = "jaypee macalalad";
            string studName3 = "aljames advincula";
            
            if (uName == "admin" & pWord == "admin")
            {
                Console.WriteLine("|============================================|");
                Console.WriteLine("|             You are logged in              |");
                Console.WriteLine("|============================================|");
                Console.WriteLine("Student List: " + "\n" + studName1 + "\n" + studName2 + "\n" + studName3);
              
                string inputStudentName = Console.ReadLine().ToLower();

                Console.WriteLine("Enter student Name: ");


          

                if (inputStudentName == (studName1))
                {
                    Console.WriteLine("Full name: Angeliko Roland Centeno" + "\n" + "Year level: 2nd Year" + "\n" + "Section: 1" + "\n" + "Course: BSIT");

                }
                else if (inputStudentName == (studName2))
                {
                    Console.WriteLine("Full name: John Patrick macalalad" + "\n" + "Year level: 2nd Year" + "\n" + "Section: 1" + "\n" + "Course: BSIT");

                }
                else if (inputStudentName == (studName3)) 
                {
                    Console.WriteLine("Full name: James Darrel Advincula" + "\n" + "Year level: 2nd Year" + "\n" + "Section: 1" + "\n" + "Course: BSIT");

                }
                else 
                {
                    Console.WriteLine("student not found");
                }

            }
            else
                Console.WriteLine("INVALID INPUT");


            Console.ReadLine();


        }
    }
}

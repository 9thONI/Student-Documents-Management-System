using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (uName == "admin" & pWord == "admin")
            {
                Console.WriteLine("|============================================|");
                Console.WriteLine("|             You are logged in              |");
                Console.WriteLine("|============================================|");
                List<string> Names = new List<string>();
                Names.Add("Angeliko Roland Centeno");
                Names.Add("John Patrick Macalalad");
                Names.Add("James Darrel Advincula");
                Names.Add("Nestor Gerona");
                Names.Add("Josel Catalan");
                Names.Add("John Edward Barreras");
               
                foreach (string name in Names)
                {
                    Console.WriteLine("Student name: " + name);
                }
                Console.WriteLine("Enter student Name: ");
                string inputName = Console.ReadLine();
    
                
                if (inputName == (""))
                {
                    Console.WriteLine("Please Select a Student");
                }
                else if (Names.Any(s => s.Equals(inputName,StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Documents not yet available");

                }
                else {
                    Console.WriteLine("Student Not Found");
                }
            }
            else
                Console.WriteLine("INVALID INPUT");
            Console.ReadLine();
        }
    }
}
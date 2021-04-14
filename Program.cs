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
            if (uName == "admin" & pWord == "admin")
            {
                Console.WriteLine("Hello Admin");

            }
            else
                Console.WriteLine("INVALID INPUT");
        }
    }
}

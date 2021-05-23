using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentDocumentsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string adminUser = "admin";
            string adminPassword = "admin";
            string AdminU, AdminPass;
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|-----Welcome to angeliko's Student Document Management System-----|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.Write("Username: ");
            AdminU = Console.ReadLine();
            Console.Write("Password: ");
            AdminPass = Console.ReadLine();
            if (AdminU == adminUser && AdminPass == adminPassword)
            {
                STUDENTS.studentList();
            }
            else
            {
                STUDENTS.exit();
            }
       
        }
       
    }
}


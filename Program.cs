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

                options();


            }
            else
            {
                Console.WriteLine("INVALID INPUT");
               
            }
            static void options()
            {
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("|--------------- Select between the options L and E ---------------|");
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine(" L - View Lists Of Students");
                Console.WriteLine(" E - Exit");
                char option = Convert.ToChar(Console.ReadLine());
                option = char.ToUpper(option);

                switch (option)
                {
                    case 'L':
                        viewStudents();
                        break;
                    case 'E':
                        exit();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                static void viewStudents()
                {

                    List<string> studName = new List<string>();
                    Console.WriteLine("|------------------------------------------------------------------|");
                    Console.WriteLine("|-------------------------- Student List --------------------------|");
                    Console.WriteLine("|------------------------------------------------------------------|");
                    studName.Add("Angeliko Roland Centeno");
                    studName.Add("John Patrick Macalalad");
                    studName.Add("James Darrel Advincula");
                    studName.Add("Nestor Gerona");
                    studName.Add("Josel Catalan");
                    studName.Add("John Edward Barreras");

                    foreach (string name in studName)
                    {

                        Console.WriteLine(name);

                    }

                    Console.WriteLine("\nEnter Student Name: ");
                    string inputName = Console.ReadLine();

                    if (inputName == (""))
                    {
                        Console.WriteLine("Please Select a Student");
                    }
                    else if (studName.Any(s => s.Equals(inputName, StringComparison.OrdinalIgnoreCase)))
                    {
                        viewFile();

                    }
                    else
                    {
                        Console.WriteLine("Student Not Found");
                    }
                }
                static void viewFile()
                {
                    Console.WriteLine("|------------------------------------------------------------------|");
                    Console.WriteLine("|-------------- Select between the options V , B , E --------------|");
                    Console.WriteLine("|------------------------------------------------------------------|");
                    Console.WriteLine(" V - View Student Files ");
                    Console.WriteLine(" B - Back to list");
                    Console.WriteLine(" E - Exit");
                    char option = Convert.ToChar(Console.ReadLine());
                    option = char.ToUpper(option);

                    switch (option)
                    {
                        case 'V':
                            files();
                            break;
                        case 'B':
                            viewStudents();
                            break;
                        case 'E':
                            exit();
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                }

            }
            static void files()
            {

                Console.WriteLine("All files are complete \n");

                exit();
            }
        }

            static void exit()
            {
                  Console.WriteLine("|------------------------------------------------------------------|");
                  Console.WriteLine("|---------------- The program is now Shutting down ----------------|");
                  Console.WriteLine("|------------------------ Have a nice Day -------------------------|");
                  Console.WriteLine("|------------------------------------------------------------------|");

            System.Environment.Exit(0);
            }

        }

    }


using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDocumentsManagementSystem
{
    class INTERFACE //wala lang ako maisip na pwede ilagay XD
    {
        public static void interFace()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|       Would you like to attach a file for this student? Y, N ,   |");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" Y - IF YES ");
            Console.WriteLine(" N - IF NO");
            char option = Convert.ToChar(Console.ReadLine());
            option = char.ToUpper(option);

            switch (option)
            {
                case 'Y':
                    FILES.showFiles();
                    break;
                case 'N':
                    STUDENTS.exit();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }

    }
}

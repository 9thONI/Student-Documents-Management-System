using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentDocumentsManagementSystem
{
    class FILES // student files
    {
        public static void showFiles()
        {
            List<string> studFile = new List<string>();
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|------------------------- STUDENT FILES --------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            studFile.Add("PSA");
            studFile.Add("FORM 137");
            studFile.Add("FORM 138");
            studFile.Add("Good moral");
            studFile.Add("Clearance");
            studFile.Add("Completion Form");
            foreach (string fileType in studFile)
            {

                Console.WriteLine(fileType);
            }
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("        PLEASE ENTER STUDENT FILE(S) FROM THE 'STUDENT FILES'       ");
            Console.WriteLine("|------------------------------------------------------------------|");
            string fileName = Console.ReadLine();

            STUDENTS studN = new STUDENTS();





            if (fileName ==(""))
            {
                Console.WriteLine("PLEASE SELECT A FILE");
                showFiles();
            }
            else if (studFile.Any(s => s.Equals(fileName, StringComparison.OrdinalIgnoreCase)))
            {


                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine(fileName + " file has been attached to  " +  studN);


            }

            else
            {
                Console.WriteLine("FILE UNRECOGNIZED");

            }

        }
    }
}    


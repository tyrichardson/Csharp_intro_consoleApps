﻿using System;
namespace AppArrayObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] objStudent = new Student[2];
            string studName, progName;
            DateTime dob;
            decimal progFees;
            for(int i=0;i<=1;++i)
            {
                Console.WriteLine($"Enter the details of the {i + 1}th student");
                Console.Write("Enter the name of student");
                studName = Console.ReadLine();
                Console.Write("Enter the name of program");
                progName = Console.ReadLine();
                Console.Write("Enter the date of birth");
                dob = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the fees");
                progFees = Convert.ToDecimal(Console.ReadLine());
                objStudent[i] = new Student(studName, progName, dob, progFees);

            }

            Console.WriteLine("Student Details");
            for(int i=0;i<=1;++i)
            {
                objStudent[i].DisplayDetails();
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        }
    }

    class Student
    {
        string name, programName;
        DateTime dateofBirth;
        decimal fees;

        public Student(string studName, string progName, DateTime dob, decimal progFees)
        {
            name = studName;
            programName = progName;
            dateofBirth = dob;
            fees = progFees;
        }

       public void DisplayDetails()
        {
            Console.WriteLine($"Name of student: {name}");
            Console.WriteLine($"Program Name: {programName}");
            Console.WriteLine($"Date of Birth: {dateofBirth}");
            Console.WriteLine($"Fees: {fees}");
        }

    }

   

   
}

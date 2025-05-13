// See https://aka.ms/new-console-template for more information
using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Grade Calculator ===");

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter marks for Subject 1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            int total = mark1 + mark2 + mark3;
            float average = total / 3.0f;
            string grade;

            if (average >= 90)
                grade = "A+";
            else if (average >= 75)
                grade = "A";
            else if (average >= 60)
                grade = "B";
            else if (average >= 40)
                grade = "C";
            else
                grade = "F";

            Console.WriteLine("\n--- Result ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Grade: " + grade);
        }
    }
}


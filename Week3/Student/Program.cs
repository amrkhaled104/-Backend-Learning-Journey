using System;
using System.Collections;
using System.Collections.Generic;
namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> info = new Dictionary<string, int>();
            Console.WriteLine("Enter Number of Students"); int num;
            while (true) {
                if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of students.");
                }
                else { break; }
               
            }

            Console.WriteLine("\nNow Enter Data:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Student[{i + 1}]");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                int grade;
                while (true)
                {
                    Console.Write("Grade (0 to 100): ");
                    if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
                }

                info[name] = grade;
                Console.WriteLine();
            }

            Console.WriteLine("Please enter the student name to get their grade");

            string Name_Search = Console.ReadLine();
            try
            {
                Console.WriteLine($"Grade {Name_Search} is {GetGrade(Name_Search, info)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public  static int GetGrade(string val,Dictionary<string,int>data)
        {
           foreach(var student in data)
            {
                if (student.Key == val)
                {
                    return student.Value;
                }
            }
            throw new DirectoryNotFoundException("Student not found.");

        }
    }
}

using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Inform the student name:");
                        Student student = new Student();
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Inform the student score:");
                        student.Score = decimal.Parse(Console.ReadLine());

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine("Please, select a option bellow:");
            Console.WriteLine("1 - Insert a new student");
            Console.WriteLine("2 - List all students");
            Console.WriteLine("3 - Calculate the score average");
            Console.WriteLine("X - Exit");
            Console.WriteLine();
            string userOption = Console.ReadLine();
            Console.WriteLine();
            return userOption;
        }
    }
}

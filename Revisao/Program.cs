using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            var studentIndex = 0;
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
                        if (decimal.TryParse(Console.ReadLine(), out decimal score))
                        {
                            student.Score = score;
                        }
                        else
                        {
                            throw new ArgumentException("You must type a decimal value to score!");
                        }
                        students[studentIndex] = student;
                        studentIndex++;
                        break;
                    case "2":
                        foreach (var a in students)
                        {
                            if (!string.IsNullOrEmpty(a.Name))
                            {
                                Console.WriteLine($"Student: {a.Name}\nScore: {a.Score}");
                            }
                        }
                        break;
                    case "3":
                        decimal total = 0;
                        var studentsAmount = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].Name))
                            {
                                total += students[i].Score;
                                studentsAmount++;
                            }

                        }
                        var average = total / studentsAmount;
                        Console.WriteLine($"Total average: {average}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
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

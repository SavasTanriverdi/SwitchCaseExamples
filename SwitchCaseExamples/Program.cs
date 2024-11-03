using System;

namespace SwitchCaseExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir gün numarası alarak haftanın gününü yazdırma
            Console.Write("Enter a number (1-7) to get the day of the week: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;
            }

            // Kullanıcıdan bir karakter alarak basit bir işlem gerçekleştirme
            Console.Write("\nEnter an operator (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result: {num1 / num2}");
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter one of +, -, *, /.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_1._2
{
    internal class Program
    {
        // PART 1 - VARIABLES
        static (int, int) equailityVariables()
        {
            // num1
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // num2
            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // return
            return (num1, num2);
        }

        // PART 3 - ADDITION
        static int AddNumbers(int var1, int var2)
        {
            int sum = var1 + var2;
            Console.WriteLine(); // spacer
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sum: {var1} + {var2} = {sum}\n");
            Console.ForegroundColor = ConsoleColor.White;
            return sum;
        }

        // PART 3 - SUBTRACTION
        static int SubNumbers(int var1, int var2)
        {
            int diff = var1 - var2;
            Console.WriteLine(); // spacer
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{var1} - {var2} = {diff}\n");
            Console.ForegroundColor = ConsoleColor.White;
            return diff;
        }

        // PART 3 - MULTIPLICATION
        static int MulNumbers(int var1, int var2)
        {
            int product = var1 * var2;
            Console.WriteLine(); // spacer
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{var1} * {var2} = {product}\n");
            Console.ForegroundColor = ConsoleColor.White;
            return product;
        }

        // PART 3 - DIVISION
        static int DivNumbers(int var1, int var2)
        {
            int quo = var1 / var2;
            Console.WriteLine(); // spacer
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{var1} / {var2} = {quo}\n");
            Console.ForegroundColor = ConsoleColor.White;
            return quo;
        }

        // PART 3 - CALCULATOR CHOICE
        static string FunctionCall(string answer)
        {
            Console.WriteLine(); // spacer
            Console.WriteLine("Please tell me what function you would like me to perform\n");
            Console.WriteLine("Type the letter for each function: \n\n" +
                "   A: Addition\n" +
                "   B: Subtraction\n" +
                "   C: Multiplication\n" +
                "   D: Division\n");
            Console.WriteLine("If you want to exit the program, type 'exit':");

            answer = Console.ReadLine();
            return answer;

        }

        // PART 3 - VARIABLES
        static (int, int) getVars()
        {
            // variable 1
            Console.Write("\nInput 1st number: ");
            int var1 = Int32.Parse(Console.ReadLine());

            // variable 2
            Console.Write("Input 2nd number: ");
            int var2 = Int32.Parse(Console.ReadLine());

            // return
            return (var1, var2);
        }


        static void Main(string[] args)
        {

            // PART 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Assignment 1.2");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.WriteLine("PART 1");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(); // spacer
            Console.WriteLine("Enter two numbers and I will tell if they are equal:\n");


            // equality checker
            char repeat = 'Y';

            while (repeat == 'Y')
            {
                var (num1, num2) = equailityVariables();

                if (num1 == num2)
                {
                    Console.WriteLine(); //spacer
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(num1 + " and " + num2 + " are equal.\n");
                }
                else
                {
                    Console.WriteLine(); //spacer
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1 + " and " + num2 + " are not equal.\n");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Try Again? (Y / N)");

                repeat = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine(); //spacer

            }



            // Transition
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(); // spacer
            Console.WriteLine("Press any key to move on to PART 2\n");
            Console.ReadKey();



            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 2");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(); // spacer

            Console.WriteLine("The first 10 natural number is :");
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10\n");

            // variables
            int i = 1;
            int sum = 0;

            // while i is less than 11
            while (i < 11)
            {
                sum += i; // shortcut for sum = sum + i
                i++; // counter. increases i by 1
            }

            // print sum
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine();


            // Transition
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any key to move on to PART 3\n");
            Console.ReadKey();


            //PART 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 3");
            Console.ForegroundColor = ConsoleColor.White;

            // variables
            string answer = null;
            string userInput = null;

            // FunctionCall 
            userInput = FunctionCall(answer).ToUpper();

            // while userInput is not "Exit"
            while (userInput != "EXIT") 
            {
                var (var1, var2) = getVars();

                switch (userInput)
                {
                    case "A":
                        AddNumbers(var1, var2);
                        break;

                    case "B":
                        SubNumbers(var1, var2);
                        break;

                    case "C":
                        MulNumbers(var1, var2);
                        break;

                    case "D":
                        DivNumbers(var1, var2);
                        break;

                    case "EXIT":
                        break;

                    default:
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("You didn't enter one of the options. Please try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                userInput = FunctionCall(answer).ToUpper();

                continue;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nHave a great day!");

            Console.ReadKey(); 

        }
    }
}

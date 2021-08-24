using System;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string choice;
            int x;
            int y;
            int output;

            var cont = true;

            while (cont) {
            Console.WriteLine("Are you [0]Adding? [1]Multiplying? [2]Subtracting? [3]Dividing?");
            option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "0":
                    case "adding":
                    case "add":
                        Console.WriteLine("Give the first number.");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to add to it?");
                        y = int.Parse(Console.ReadLine());
                        output = Add(x, y);
                        Console.WriteLine($"{x} + {y} = {output}");
                        break;
                    case "1":
                    case "multiplying":
                    case "multiply":
                        Console.WriteLine("Give the first number.");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to multiply it by?");
                        y = int.Parse(Console.ReadLine());
                        output = Multiply(x, y);
                        Console.WriteLine($"{x} x {y} = {output}");
                        break;
                    case "2":
                    case "subtracting":
                    case "subtract":
                        Console.WriteLine("Give the first number.");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to subtract from it? Please be sure the number is not greater than your original.");
                        y = int.Parse(Console.ReadLine());
                        if (x >= y)
                        {
                            output = Subtract(x, y);
                            Console.WriteLine($"{x} - {y} = {output}");
                        }
                        else
                        {
                            Console.WriteLine("This program does not support negatives for its results.");
                        }
                        break;
                    case "3":
                    case "dividing":
                    case "divide":
                        Console.WriteLine("Give the first number.");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("What do you want to it divide by? Please be sure the number is not greater than your original.");
                        y = int.Parse(Console.ReadLine());
                        if (x >= y)
                        {
                            output = Divide(x, y);
                            int remainder = Remainder(x, y);

                            if (remainder == 0)
                            {
                                Console.WriteLine($"{x} / {y} = {output}");
                            }
                            else
                            {
                                Console.WriteLine($"{x} / {y} = {output} with a remainder of {remainder}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This program does not support answers that result in being less than 1.");
                        }
                        break;
                    default:
                        Console.WriteLine("Improper input");
                        break;
                }

                Console.WriteLine("Would you like to calculate something else?");
                choice = Console.ReadLine();
                if (choice.ToLower() != "y" && choice.ToLower() != "yes")
                {
                    cont = false;
                }
            }
        }
        
        public static int Add(int num1, int num2)
        {
            int x = num1 + num2;
            return x;
        }

        public static int Multiply(int num1, int num2)
        {
            int x = num1 * num2;
            return x;
        }

        public static int Subtract(int num1, int num2)
        {
            int x = num1 - num2;
            return x;
        }
        public static int Divide(int num1, int num2)
        {
            int x = num1 / num2;
            return x;
        }
        public static int Remainder(int num1, int num2)
        {
            int x = num1 % num2;
            return x;
        }
    }
}

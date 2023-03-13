using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter the number for the function you would like to use:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Powers");
                Console.WriteLine("6. Roots");
                Console.WriteLine();
                Console.WriteLine("7. Exit");

                int function = Convert.ToInt32(Console.ReadLine());
                switch (function)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Please enter the first number:");
                        int addFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("+");
                        int addSecond = Convert.ToInt32(Console.ReadLine());

                        int addTotal = addFirst + addSecond;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(addTotal);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        int subFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-");
                        int subSecond = Convert.ToInt32(Console.ReadLine());

                        int subTotal = subFirst - subSecond;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(subTotal);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        int multiFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("*");
                        int multiSecond = Convert.ToInt32(Console.ReadLine());

                        int multiTotal = multiFirst * multiSecond;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(multiTotal);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        int divFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("÷");
                        int divSecond = Convert.ToInt32(Console.ReadLine());

                        int divTotal = divFirst / divSecond;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(divTotal);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Enter the number you want to raise:");
                        double powerFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the power");
                        double powerSecond = Convert.ToInt32(Console.ReadLine());

                        double powerTotal = Math.Pow(powerFirst, powerSecond);
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(powerTotal);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Enter the number you want to find the root of:");
                        double rootFirst = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the root number");
                        double rootSecond = Convert.ToInt32(Console.ReadLine());

                        double rootTotal = Math.Pow(rootFirst, 1.0 / rootSecond);
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(rootTotal);
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine();
                        Console.WriteLine("Exiting...");
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid selection, please re-enter:");
                        break;
                }
            }
            while (true);
            
        }
    }
}
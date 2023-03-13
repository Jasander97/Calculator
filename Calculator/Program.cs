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
                        int numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("+");
                        int numTwo = Convert.ToInt32(Console.ReadLine());

                        double product = numOne + numTwo;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
                        Console.WriteLine();
                        break;
                        
                    case 2:
                        
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("-");
                        numTwo = Convert.ToInt32(Console.ReadLine());

                        product = numOne - numTwo;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
                        Console.WriteLine();
                        break;
                        
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("*");
                        numTwo = Convert.ToInt32(Console.ReadLine());

                        product = numOne * numTwo;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Enter the first number:");
                        numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("÷");
                        numTwo = Convert.ToInt32(Console.ReadLine());

                        product = numOne / numTwo;
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Enter the number you want to raise:");
                        numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the power");
                        numTwo = Convert.ToInt32(Console.ReadLine());

                        product = Math.Pow(numOne, numTwo);
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Enter the number you want to find the root of:");
                         numOne = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the root number");
                         numTwo = Convert.ToInt32(Console.ReadLine());

                         product = Math.Pow(numOne, 1.0 / numTwo);
                        Console.WriteLine();
                        Console.WriteLine("=");
                        Console.WriteLine(product);
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
namespace ConsoleApp
{
    internal class Program
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Basic Calculator!");
                int flag = 1;
                while (Convert.ToBoolean(flag))
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Choose any operation:");
                    Console.WriteLine("1. Addition (+)");
                    Console.WriteLine("2. Subtraction (-)");
                    Console.Write("Enter your choice (1 or 2): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    double result = 0;
                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine($"Result of Addition: {result}");
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine($"Result of Subtraction: {result}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                    Console.Write("Press 1 to continue another operation and press 0 to exit: ");

                    flag = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}

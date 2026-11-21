using System;

class Program
{
    static void Main()
    {
        double radius;
        double result;
        char choice;

        Console.WriteLine(“===== CIRCLE CALCULATOR =====“);
        Console.WriteLine(“A - Compute Area”);
        Console.WriteLine(“P - Compute Perimeter”);
        Console.WriteLine(“X - Exit”);

        Console.Write(“Enter your choice: “);
        choice = Convert.ToChar(Console.ReadLine().ToUpper());
        if (choice == ‘X’)
        {
            Console.WriteLine(“Exiting the application.”);
        }
        else
        {
            Console.Write(“Enter the radius: “);
            radius = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case ‘A’:
                    result = Math.PI * radius * radius;
                    Console.WriteLine(“Area = “ + result);
                    break;

                case ‘P’:
                    result = 2 * Math.PI * radius;
                    Console.WriteLine(“Perimeter = “ + result);
                    break;

                default:
                    Console.WriteLine(“Invalid choice.”);
                    break;
            }
        }
    }
}
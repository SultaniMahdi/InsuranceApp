using System;

namespace InsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Insurance Premium Calculator ===\n");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of your car (€): ");
            double carValue = Convert.ToDouble(Console.ReadLine());

            double baseRate = 0.03; // 3% of car value
            double ageFactor = age < 25 ? 1.5 : 1.0;

            double premium = carValue * baseRate * ageFactor;

            Console.WriteLine($"\nYour estimated annual premium is: €{premium:F2}");
        }
    }
}

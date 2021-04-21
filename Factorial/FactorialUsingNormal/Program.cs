using System;

namespace FactorialUsingNormal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, result;
            Console.WriteLine("Enter a non negative number:");
            number=Convert.ToInt32(Console.ReadLine());
            result = number;
            for(i=number-1; i>=1; i--)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of given number is : " +result);
            Console.ReadLine();
        }
    }
}

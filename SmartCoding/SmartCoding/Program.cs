using System;

namespace SmartCoding
{
    
    public class Program
    {
        public static bool IsPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private static void Main(string[] args)
        {
            long numberToTest = 3367900313;
            IsPrime(numberToTest);
            Console.ReadLine();
        }

        private static void Calc()
        {
            Console.WriteLine("Make a choice 1.add 2.sub 3.multiply 4.divide");
            //heyya! tats me!!!!!

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine(a + b); break;
                case 2: Console.WriteLine(a - b); break;
                case 3: Console.WriteLine(a * b); break;
                case 4: Console.WriteLine(a / b); break;
            }

            Console.ReadLine();
        }
    }
}
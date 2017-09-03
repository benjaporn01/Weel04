
using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a,randomNumber = random.Next(0, 9);
            bool b;
            Console.Write("Enter nember:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Random number:{0}",randomNumber);
            b = a > randomNumber;
            Console.WriteLine("Boolean {0} > {1} is {2}",a,randomNumber,b);
            Console.ReadKey();
        }
    }
}

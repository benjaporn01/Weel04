using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : char");
            Console.WriteLine("Size :" + sizeof(char));
            Console.WriteLine("Minimum Value :" + (int)char.MinValue);
            Console.WriteLine("Maximum Value :" + (int)char.MaxValue);
        }
    }
}

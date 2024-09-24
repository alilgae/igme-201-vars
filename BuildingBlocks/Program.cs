using System.Reflection.Metadata;

namespace BuildingBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int newInt = 17;

            int anotherInt = newInt + 12;


            String print = "Hello, ";
            print += "IGME 201!";

            print += " My two numbers are: " + newInt + ", and " + anotherInt;

            Console.WriteLine(print);


        }
    }
}

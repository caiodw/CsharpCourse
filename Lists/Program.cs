using System.Collections.Generic;
namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);

            List<int> number2 = new List<int>()
            {
                1,6,7,10,14
            };

            Console.WriteLine(number2.Count);

            number2.Add(55);
            Console.WriteLine(number2.Count);

            numbers.Clear();
            Console.WriteLine(numbers.Count);

            List<string> countries = new List<string>()
            {
                "México","Argentina","Espana"
            };

            Console.WriteLine(countries.Count);
        }
    }
}
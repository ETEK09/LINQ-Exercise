using System;
using System.Collections.Concurrent;
using System.Linq;



namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var myList = new List<string>() { "a", "b", "c" };

            //var myArray = new string[] { "hi", "hello", "how are you" };

            var ages = new List<int>() { 17, 32, 12, 45, 62, 70 };

            var greatestAge = ages.Max();

            var minAge = ages.Min();

            //var sorted = ages.OrderBy(age => age);

            ages.Sort();

            //var votingAgges = ages.Where(number => number >= 18);

            //var votingAges = new List<int>();

            foreach (var age in ages)
            {

                //if (number >= 18)
                {
                  Console.WriteLine(age);

                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list
            List<int> randomNumbers = new List<int>();
            List<int> squaredNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            for(var i = 1; i <= 20; i++)
            {
                randomNumbers.Add(random.Next(1, 51));
            }
            // 1. Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            // Populate the list
            foreach (var i in randomNumbers)
            {
                Console.WriteLine($"random {i}");
                squaredNumbers.Add(i * i);
                if(i % 2 != 1)
                {
                    evenNumbers.Add(i);
                }

            }
            // 2. With the resulting List, populate a new List that contains each number squared.
            foreach(var j in squaredNumbers)
            {
                Console.WriteLine($"squared {j}");
            }
            // 3. Then remove any number that is odd from the list of squared numbers.
            foreach (var x in evenNumbers)
            {
                Console.WriteLine($"even {x}");
            }
        }
    }
}

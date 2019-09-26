using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestAndHighestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string highestLowestString = "1 9 3 4 -5";
            Console.WriteLine(HighestLowestNumbers(highestLowestString));
            Console.WriteLine(HighAndLow(highestLowestString));
        }

        static string HighestLowestNumbers(string highestLowestNumbers)
        {
            // split the string into an aray of chars
            string[] characterDelimiter = { Environment.NewLine, " "};
            int[] numbers = highestLowestNumbers.Split(characterDelimiter, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Int32.Parse(x)).ToArray();
            Array.Sort(numbers);

            return highestLowestNumbers = numbers.Last() + " " + numbers.First().ToString();
        }

        static string HighAndLow(string numbers)
        {
            var parsedNumbers = numbers.Split().Select(int.Parse);
            return $"{parsedNumbers.Max()} {parsedNumbers.Min()}";
        }
    }
}

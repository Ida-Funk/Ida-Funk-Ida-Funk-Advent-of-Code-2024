// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using Advent_of_Code_2024.Day1;
// using Advent_of_Code_2024;


namespace Advent_of_Code_2024
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
            int sum = await Day1_1.SumDiff();

            Console.WriteLine($"Day1.1 sum: {sum}");

            return sum;
        }
    }
}



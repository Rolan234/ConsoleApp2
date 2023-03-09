using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] array = new int [] {    };
            int[] array = { 37, 0, 50, 46, 34, 46, 0, 13 };
            foreach (int element in array)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadLine();
        }

    }
}

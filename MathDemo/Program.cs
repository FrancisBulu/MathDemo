using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 548.65;
            Console.WriteLine($"Floor value of {num1} is {Math.Floor(num1)}");
            Console.WriteLine($"Cell value of {num1} is {Math.Ceiling(num1)}");
            Console.WriteLine($"Round {num1} to {Math.Round(num1)}");
            char kar = 'a';
            Console.WriteLine((int)kar);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[2] = 3;

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}

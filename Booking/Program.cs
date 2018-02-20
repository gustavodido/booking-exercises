using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new[] { 1, 101, 10002, 10008, 10, 10, 40, 2, 3, 20, 100, 8, 0 };
            BubbleSort.Sort(intArray);

            foreach (var i in intArray)
                Console.Write(i + " ");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class Fibonnaci
    {
        [TestMethod]
        public void FibonnaciTest()
        {
            int[] r = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            var fib = new List<int>();
            fib.Add(0);
            fib.Add(1);

            int count = 15;

            for(int i = 2; i < count; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }

            CollectionAssert.AreEqual(r, fib.ToArray());
        }
    }

}

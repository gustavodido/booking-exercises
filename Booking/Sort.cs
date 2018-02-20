using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void SimpleArraySorting()
        {
            var intArray = new[] { 1, 101, 10002, 10008, 10, 10, 40, 2, 3, 20, 100, 8, 0 };
            BubbleSort.Sort(intArray);

            var sortedArray = new List<int>(intArray);
            sortedArray.Sort();

            CollectionAssert.AreEqual(intArray, sortedArray);
        }        
    }

    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
        }
    }
}

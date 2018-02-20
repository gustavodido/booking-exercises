using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class BinarySearchTestCases
    {
        [TestMethod]
        public void SimpleValidBinarySearch()
        {
            var intArray = new[] { 1, 101, 10002, 10008, 10, 10, 40, 2, 3, 20, 100, 8, 0 };
            BubbleSort.Sort(intArray);

            foreach (var element in intArray)
                Assert.IsTrue(BinarySearch.Search(intArray, element));
        }

        [TestMethod]
        public void SimpleInvalidBinarySearch()
        {
            var invArray = new[] { 1000, 87, 74, 102, 21, 13 };        
            var intArray = new[] { 1, 101, 10, 10, 40, 2, 3, 20, 100, 8, 0 };
            foreach (var element in invArray)
                Assert.IsFalse(BinarySearch.Search(intArray, element));
        }
    }
    public class BinarySearch
    {
        private static bool InternalSearch(int[] array, int left, int right, int element)
        {
            if (right < left)
                return false;

            int mid = (left + right) / 2;

            if (array[mid] > element)
                return InternalSearch(array, left, mid - 1, element);
            else if (array[mid] < element)
                return InternalSearch(array, mid + 1, right, element);
            else
                return true;
        }

        public static bool Search(int[] array, int element)
        {
            return InternalSearch(array, 0, array.Length - 1, element);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void GivenArraySimple()
        {
            int[] a = { 3, 1, 2, 3, 4, 2, 3 };
            int[] b = { 2, 3, 6, 2, 5, 2, 2, 3 };
            
            int[] c = a.Intersect(b).ToArray();
            int[] i = new [] { 3, 2 };

            // O (m *n ), we could write a solution with a hashmap in O(N)
            var d = new List<int>();
            foreach (var item in a)
                foreach (var s in b)
                    if (item == s)
                        d.Add(item);

            CollectionAssert.AreEqual(c, i);
            CollectionAssert.AreEqual(d.Distinct().ToArray(), i);
        }

        [TestMethod]
        public void GivenArrayHash()
        {
            int[] a = { 3, 1, 2, 3, 4, 2, 3 };
            int[] b = { 2, 3, 6, 2, 5, 2, 2, 3 };

            int[] c = a.Intersect(b).ToArray();
            int[] i = new[] { 3, 2 };

            // hashmap in O(N)
            var d = new Dictionary<int, int>();
            foreach (var item in a)
                if (!d.ContainsKey(item))
                    d.Add(item, 0);

            foreach (var item in b)
                if (d.ContainsKey(item))
                    d[item] = 1;

            var e = d.Where(p => p.Value > 0)
                        .Select(p => p.Key)
                        .ToArray();

            CollectionAssert.AreEqual(c, i);
            CollectionAssert.AreEqual(e, i);
        }
    }

    class GivenArray
    {
    }
}
    
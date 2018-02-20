using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booking
{
    [TestClass]
    public class FileNavigation
    {
        public interface Node
        {
            
        }

        public class DirectoryNode: Node
        {
            public DirectoryNode()
            {
                Files = new List<Node>();    
            }

            public List<Node> Files { get; set; }     
        }

        public class FileNode: Node
        {
            public int Value { get; set; }
        }

        private DirectoryNode _rootNode;

        public void Construct()
        {
            _rootNode = new DirectoryNode();
            for(int i = 0; i < 10; i++)
                _rootNode.Files.Add(new FileNode { Value = i });

            var second = new DirectoryNode();
            for (int i = 10; i < 15; i++)
                (second).Files.Add(new FileNode { Value = i });

            _rootNode.Files.Add(second);

            var third= new DirectoryNode();
            for (int i = 15; i < 20; i++)
                (third).Files.Add(new FileNode { Value = i });

            second.Files.Add(third);
        }

        [TestMethodAttribute]
        public void FileNavigationTest()
        {
            Construct();

            var size = GetSize(_rootNode);

            var sum = 0;
            for (int i = 0; i < 20; i++)
                sum += i;

            Assert.AreEqual(size, sum);
        }

        private int GetSize(Node node)
        {
            if (node is FileNode) 
                return ((FileNode) node).Value;
            
            var dir = (DirectoryNode) node;
            return dir.Files.Sum(f => GetSize(f));
        }
    }
}

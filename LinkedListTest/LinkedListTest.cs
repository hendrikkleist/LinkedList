using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListLibrary;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void AddFirstTest()
        {
            LinkedList linkedList = new LinkedList();
            Element element = new Element();

            element.Data = 7;

            linkedList.AddFirst(element);
            Assert.AreEqual<int>(element.Data, linkedList.First.Data);
        }

        [TestMethod]
        public void RemoveFirstTest()
        {
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            linkedList.RemoveFirst();

            Assert.AreEqual<int>(element2.Data, linkedList.First.Data);
        }

        [TestMethod]
        public void CountTest()
        {
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            Assert.AreEqual<int>(2, linkedList.Count());
        }

        [TestMethod]
        public void PrintTest()
        {
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            string expected = "7\n10\n";
            Assert.AreEqual(expected, linkedList.Print(), true);
        }

        [TestMethod]
        public void SortTest()
        {
            LinkedList linkedList = new LinkedList();
            Element element4 = new Element();
            element4.Data = 7;
            linkedList.AddFirst(element4);

            Element element3 = new Element();
            element3.Data = 2;
            linkedList.AddFirst(element3);

            Element element2 = new Element();
            element2.Data = 1;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 10;
            linkedList.AddFirst(element1);
            linkedList.Sort();

            string expected = "1\n2\n7\n10\n";
            Assert.AreEqual(expected, linkedList.Print());

        }
    }

}

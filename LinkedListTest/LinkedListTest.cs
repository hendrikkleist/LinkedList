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
            // Arrange
            LinkedList linkedList = new LinkedList();

            Element element3 = new Element();
            linkedList.AddFirst(element3);
            Element element2 = new Element();
            linkedList.AddFirst(element2);
            Element element1 = new Element();
            element1.Data = 7;

            // Act
            linkedList.AddFirst(element1);

            // Assert
            Assert.AreEqual<int>(element1.Data, linkedList.First.Data);
        }

        [TestMethod]
        public void RemoveFirstTest()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            // Act
            linkedList.RemoveFirst();

            // Assert
            Element expected = element2;
            Assert.AreEqual<int>(expected.Data, linkedList.First.Data);
        }

        [TestMethod]
        public void CountTest()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            // Act
            int actual = linkedList.Count();

            // Assert
            int expected = 2;
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void PrintTest()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            Element element2 = new Element();
            element2.Data = 10;
            linkedList.AddFirst(element2);

            Element element1 = new Element();
            element1.Data = 7;
            linkedList.AddFirst(element1);

            // Act
            string actual = linkedList.Print();

            // Assert
            string expected = "7\n10\n";
            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void SortTest()
        {
            // Arrange
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

            // Act
            linkedList.Sort();
            string actual = linkedList.Print();

            // Assert
            string expected = "1\n2\n7\n10\n";
            Assert.AreEqual(expected, actual);

        }
    }

}

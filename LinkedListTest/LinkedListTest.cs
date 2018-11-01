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
            int actual = linkedList.First.Data;
            
            // Assert
            int expected = element1.Data;
            Assert.AreEqual<int>(expected, actual);
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
            Element e4 = new Element();
            e4.Data = 1;
            linkedList.AddFirst(e4);

            Element e3 = new Element();
            e3.Data = 2;
            linkedList.AddFirst(e3);

            Element e2 = new Element();
            e2.Data = 7;
            linkedList.AddFirst(e2);

            Element e1 = new Element();
            e1.Data = 10;
            linkedList.AddFirst(e1);



            // Act
            linkedList.Sort();
            string actual = linkedList.Print();

            // Assert
            string expected = "1\n2\n7\n10\n";
            Assert.AreEqual(expected, actual);

        }
    }

}

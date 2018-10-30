using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListLibrary;


namespace LinkedListTest
{
    [TestClass]
    public class ElementTest
    {
        [TestMethod]
        public void CreateElementTest()
        {
            // Arrange
            Element arrange = new Element();
            arrange.Data = 5;
            Element element = new Element(arrange.Data, null);
 
            // Assert
            Assert.AreEqual<int>(arrange.Data, element.Data);
        }
    }
}

using System;

namespace LinkedListLibrary
{
    public class Element
    {
        /// <summary>
        /// Value of the element
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Reference to the next element
        /// </summary>
        public Element Next { get; set; }


        public Element(int data, Element next)
        {
            Data = data;
            Next = next;
        }

        public Element()
        {
            Random rnd = new Random();
            Data = rnd.Next(0, 100);   // creates a number between 0 and 99
            Next = null;
        }
    }
}

using System;

namespace LinkedListLibrary
{
    public class Element
    {
        private int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Element Next { get; set; }

        public Element(int data, Element next)
        {
            Data = data;
            Next = next;
        }

        public Element()
        {
            Random rnd = new Random();
            Data = rnd.Next(0, 100);   // creates a number between 1 and 6
            Next = null;
        }
    }
}

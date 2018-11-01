using System;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        /// <summary>
        /// First element of the linked list
        /// </summary>
        public Element First { get; set; }

        /// <summary>
        /// Constructs a linked list with empty Element
        /// </summary>
        public LinkedList()
        {
            First = null;
        }

        /// <summary>
        /// <para>Adds an element to the linked list.</para>
        /// <para>If an element already exists it takes the First element</para>
        /// and attaches it to the Next property.
        /// <para>If the list is empty, the element is just added to the list.</para>
        /// </summary>
        /// <param name="element">Used to add to the list</param>
        public void AddFirst(Element element)
        {
            // Check if Element is empty
            if (First == null)
            {
                // Sets the first element
                First = element;
            } else
            {
                // Sets the Next element
                element.Next = First;
                // Sets the First element
                First = element;
            }
        }

        /// <summary>
        /// Removes the first element of the list
        /// </summary>
        public void RemoveFirst()
        {
            // Check if Element is empty
            if (First == null)
            {
                Console.WriteLine("Ingen Data i linkedlist");
            } else
            {
                // Sets the next Element as First Element
                // Garbage collector will make sure to delete unused Element
                First = First.Next;
            }
        }

        /// <summary>
        /// Counts the elements in the list
        /// </summary>
        /// <returns>Integer representing number of elements in the list</returns>
        public int Count()
        {
            // Make a reference to the First element.
            // Otherwise it will be destructive count
            Element localFirst = First;
            int counter = 0;
            bool end = false;
            while (!end)
            {
                // If localFirst is empty, there are no elements in the list
                if (localFirst == null)
                {
                    end = true;
                }
                else
                {
                    // There are element(s) in the list, increment counter with 1
                    counter++;
                    // See if there's an next element in the first element
                    if (localFirst.Next == null)
                    {
                        // We are at the end of the list
                        end = true;
                    }
                    else
                    {
                        // Set the next element as first element
                        localFirst = localFirst.Next;
                    }
                }
            }
            return counter;
        }

        /// <summary>
        /// Returns the linked list as string.
        /// </summary>
        /// <returns>The list element.data as string</returns>
        public string Print()
        {
            // Make a reference to the First element.
            // Otherwise it will be destructive print
            Element localFirst = First;
            string result = "";
            bool end = false;
            while (!end)
            {
                // If localFirst is empty, there are no elements in the list
                if (localFirst == null)
                {
                    // We are at the end of the list
                    end = true;
                }
                else
                {
                    // There are element(s) in the list, add the data to the result
                    result += localFirst.Data.ToString() + "\n";
                    if (localFirst.Next == null)
                    {
                        // We are at the end of the list
                        end = true;
                    }
                    else
                    {
                        // Set the next element as first element
                        localFirst = localFirst.Next;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Sorts the list in the ascending order
        /// </summary>
        public void Sort()
        {
            // Make a reference to the First element.
            
            int linkedCount = Count();
            
            for (int i = 0; i < linkedCount; i++)
            {
                // Otherwise it will be destructive sort
                Element localFirst = First;
                bool end = false;
                while (!end)
                {
                    if (localFirst == null)
                    {
                        end = true;
                    }
                    else
                    {
                        if (localFirst.Next == null)
                        {
                            end = true;
                        }
                        else
                        {
                            if (localFirst.Data > localFirst.Next.Data)
                            {
                                int temp = localFirst.Next.Data;
                                localFirst.Next.Data = localFirst.Data;
                                localFirst.Data = temp;
                            }
                            localFirst = localFirst.Next;
                        }
                    }
                }
            }
        }
    }
}

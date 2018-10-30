using System;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        public Element First { get; set; }

        public LinkedList()
        {
            First = null;
        }

        public void AddFirst(Element element)
        {
            if (First == null)
            {
                First = element;
            } else
            {
                element.Next = First;
                First = element;
            }
        }

        public void RemoveFirst()
        {
            if(First == null)
            {
                Console.WriteLine("Ingen Data i linkedlist");
            } else
            {
                Element next = First.Next;
                First = null;
                First = next;
            }
        }

        public int Count()
        {
            Element localFirst = First;
            int counter = 0;
            bool end = false;
            while (!end)
            {
                if (localFirst == null)
                {
                    end = true;
                }
                else
                {
                    counter++;
                    if (localFirst.Next == null)
                    {
                        end = true;
                    }
                    else
                    {

                        localFirst = localFirst.Next;
                    }
                }
            }
            return counter;
        }

        public string Print()
        {
            Element localFirst = First;
            string result = "";
            bool end = false;
            while (!end)
            {
                if (localFirst == null)
                {
                    end = true;
                }
                else
                {
                    result += localFirst.Data.ToString() + "\n";
                    if (localFirst.Next == null)
                    {
                        end = true;
                    }
                    else
                    {

                        localFirst = localFirst.Next;
                    }
                }
            }
            return result;
        }

        public void Sort()
        {
            LinkedList linkedList = new LinkedList();
            int linkedCount = Count();
            
            for (int i = 0; i < linkedCount; i++)
            {
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

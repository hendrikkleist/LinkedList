using System;
using LinkedListLibrary;

namespace TUI
{
    class Program
    {
        private static bool finished = false;
        private static LinkedList linkedList;
        static void Main(string[] args)
        {
            linkedList = new LinkedList();
            while(!finished)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("A/a to Add element to linked list");
                Console.WriteLine("R/r to Remove element from linked list");
                Console.WriteLine("C/c to Count elements of link list");
                Console.WriteLine("P/p to Print elements");
                Console.WriteLine("S/s to Sort elements");
                Console.WriteLine("Q/q to quit program");
                Console.WriteLine("********************************************");
                Console.Write("Indtast dit valg: ");
                string choice = Console.ReadLine();
                choice = choice.ToUpper();
                switch (choice)
                {
                    case "A":
                        Element element = new Element();
                        linkedList.AddFirst(element);
                        Console.WriteLine(linkedList.Print());
                        break;
                    case "R":
                        linkedList.RemoveFirst();
                        Console.WriteLine(linkedList.Print());
                        break;
                    case "C":
                        Console.WriteLine("Antal i listen: " + linkedList.Count().ToString());
                        break;
                    case "P":
                        Console.WriteLine(linkedList.Print());
                        break;
                    case "S":
                        Console.WriteLine(linkedList.Print());
                        linkedList.Sort();
                        Console.WriteLine(linkedList.Print());
                        break;
                    case "Q":
                        finished = true;
                        Console.WriteLine("Program terminated. Press enter to close the command promt.");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

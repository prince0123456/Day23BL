﻿using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }

        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Prince");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Hemraj");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach(var element in dictionary)
            {
                Console.WriteLine("Key ="+element.Key+" & Value ="+element.Value);
            }
        }

        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Prince");
            set.Add("Delta");
            set.Add("Bravo");
            set.Add("Alfa");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueDemo");

            //Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Prince");
            queue.Enqueue("Hemraj");
            queue.Enqueue("Vibin");
            Console.WriteLine("Head:"+queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");
            
            // Iterating Queue elements  
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:"+dequeue);

            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            // Iterating Queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }  
        }

        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            //Creating Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Prince");
            stack.Push("Golu");
            stack.Push("Amit");
            stack.Push("Kushi");
            stack.Push("Hemi");
            string pop = stack.Pop();

            // Iterating stack elements  
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: "+pop);
        }

        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Prince");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            // Iterating list elements  
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}

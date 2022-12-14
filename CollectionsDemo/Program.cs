using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doDictionaryDemo();
            Console.ReadLine(); 
        }
        public static void doListDemo()
        {
            Console.WriteLine("dolist method");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void doStackDemo()
        {
            Console.WriteLine("stack collection demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("harish");
            stack.Push("hiran");
            stack.Push("chetan");
            stack.Push("dwayne");
           string pop= stack.Pop();
            Console.WriteLine("poped element from stack {0}",pop);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void doQueueDemo()
        {
            Console.WriteLine("queue collection demo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Raj");
            queue.Enqueue("Ramesh");
            queue.Enqueue("Suresh");
            queue.Enqueue("Tanmay");
            queue.Enqueue("Kiran");
            queue.Dequeue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public static void doDictionaryDemo()
        {
            Console.WriteLine("DIctionary collection Demo");
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");

            Console.WriteLine("Accessing using key 100  which contains the value "+dictionary[100]);

            foreach(var item in dictionary)
            {
                Console.WriteLine("key= " + item.Key + " and " + "value= " + item.Value);
            }
        }
    }
}

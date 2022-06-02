using System;
using System.Collections.Generic;

namespace dataStructuresCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>
            Console.WriteLine("__DICTIONARY__"); 
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
            openWith["rtf"] = "windword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]); 

            if(!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]); 
            }

            Console.WriteLine(); 
            foreach(KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, value = {1}", kvp.Key, kvp.Value); 
            }

            Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
            Console.WriteLine(); 
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s); 
            }

            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
            Console.WriteLine(); 
            foreach(string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s); 
            }

            Console.WriteLine("\nRemove (\"doc\")");
            openWith.Remove("doc"); 

            if(!openWith.ContainsKey("doc")){ Console.WriteLine("Key \"doc\" is not found"); }


            //List<T>
            Console.WriteLine(); 
            Console.WriteLine("__LIST__"); 
            List<string> dinosaurs = new List<string>();
            
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            Console.WriteLine(); 
            foreach(string dinosaur in dinosaurs){ Console.WriteLine(dinosaur); }

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);
            Console.WriteLine("\nContains(\"Deinonychus\"): {0}", dinosaurs.Contains("Deinonychus"));
            Console.WriteLine("\nInsert(2, \"Compsognathus\")");
            dinosaurs.Insert(2, "Compsognathus");
            Console.WriteLine(); 

            foreach(string dinosaur in dinosaurs){ Console.WriteLine(dinosaur); }

            Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);
            Console.WriteLine("\nRemove(\"Compsognathus\")");
            dinosaurs.Remove("Compsognathus");

            Console.WriteLine();
            foreach(string dinosaur in dinosaurs) { Console.WriteLine(dinosaur); }

            dinosaurs.TrimExcess();
            Console.WriteLine("\nTrimExcess()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            dinosaurs.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);


            //Queue<T> 
            Console.WriteLine();
            Console.WriteLine("___QUEUE___");
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach(string number in numbers) { Console.WriteLine(number); }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at the next item in the queue: {0}", numbers.Peek());
            Console.WriteLine("Dequeueing '{0}'", numbers.Dequeue());

            //Create a copy of the Queue, using the ToArray method and the constructor
            //that accepts IEnumerable<T>
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy:"); 
            foreach(string number in queueCopy) { Console.WriteLine(number); }

            //Stack<T>
            Console.WriteLine();
            Console.WriteLine("__STACK__");
            Stack<string> nums = new Stack<string>();
            nums.Push("one");
            nums.Push("two"); 
            nums.Push("three"); 
            nums.Push("four"); 
            nums.Push("five");
            
            foreach(string num in nums) { Console.WriteLine(num); }
            Console.WriteLine("\nPopping '{0}'", nums.Pop());
            Console.WriteLine("\nPeek at the next element: {0}", nums.Peek());
            Console.WriteLine("Popping '{0}'", nums.Pop());

            //Creat a copy of the stack using the toArray method and the constructor
            //that accepts an IEnumerable<T>; 
            Stack<string> stack2 = new Stack<string>(nums.ToArray());
            Console.WriteLine("\nContents of the first copy:"); 
            foreach(string num in stack2) { Console.WriteLine(num); }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}", stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count() = {0}", stack2.Count); 


        }
    }
}

using System;
using System.Collections.Generic;

namespace dataStructuresCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<TKey, TValue>
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

            if(!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found"); 
            }

        }
    }
}

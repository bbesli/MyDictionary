using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Burak");
            myDictionary.Add("Deniz");
            myDictionary.Add("Bozca");

            Console.WriteLine(myDictionary.Count);
        }
    }
}

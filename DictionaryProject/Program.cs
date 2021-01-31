using System;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new DictionaryProject.MyDictionary<int, string>();
            myDictionary.Add(61, "Fırat");
            myDictionary.Add(12, "Mustafa");

        }
    }
}

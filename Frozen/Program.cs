using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string item;
            

            public Frozen(string _name, string _item)
            {
                name = _name;
                item = _item;
            }

            public string Name { get { return name; } }

            public string Item { get { return item; } }


        }

        class FrozenList
        {
            List<Frozen> characters;
            

            public FrozenList()
            {
                characters = new List<Frozen>();
                
            }
            public void AddFrozenList(string _name,string _item)
            {
                Frozen newFrozen = new Frozen(_name, _item);
                characters.Add(newFrozen);
            }
            public void PrintAllFrozens()
            {
                foreach (Frozen characters in characters)
                {
                    Console.WriteLine($"{characters.Name} wants {characters.Item} for Holidays");
                }
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"frozen.txt";
            string fullPath = Path.Combine(filePath, fileName);
            string[] linesFromFile = File.ReadAllLines(fullPath);

            FrozenList character = new FrozenList();
            foreach(string line in linesFromFile)
            {
                string[] temparray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string characterName = temparray[0];
                string characterItem = temparray[1];
                character.AddFrozenList(characterName, characterItem);
            }
                character.PrintAllFrozens();
        }
    }
}

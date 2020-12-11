using System;
using System.IO;
using System.Collections.Generic;

namespace frozen
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

            internal static void PrintAll()
            {
                throw new NotImplementedException();
            }
        }

        class FrozenList
        {
            List<Frozen> frozens;


            public FrozenList()
            {
                frozens = new List<Frozen>();

            }

            public void AddFrozenToList(string name, string item)
            {
                Frozen newFrozen = new Frozen(name, item);
                frozens.Add(newFrozen);
            }

        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"frozenl.txt";
            string fullFilePath = Path.Combine(filePath, fileName);

            string[] linesFromfile = File.ReadAllLines(fullFilePath);

            FrozenList myFrozen = new FrozenList();

            foreach (string line in linesFromfile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string frozenName = tempArray[0];
                string FrozenItem = tempArray[1];


                myFrozen.AddFrozenToList(frozenName, FrozenItem);

            }
            Frozen.PrintAll();

        }

    }
}
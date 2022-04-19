using System;
using System.Collections.Generic;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> libraryOfNames = new Dictionary<string, string>();
            libraryOfNames.Add("Вася", "Vasya");
            libraryOfNames.Add("Коля", "Kolya");
            libraryOfNames.Add("Дима", "Dima");
            libraryOfNames.Add("Витя", "Vitya");
            libraryOfNames.Add("Аня", "Anya");
            libraryOfNames.Add("Таня", "Tanya");

            bool isContinueCycle = true;

            while (isContinueCycle)
            {
                Console.Clear();

                foreach (var nameRu in libraryOfNames)
                {
                    Console.WriteLine(" "+nameRu.Key);
                }

                Console.Write("Введите имя - ");

                string collectionKey = Console.ReadLine();

                if (libraryOfNames.ContainsKey(collectionKey))
                {
                    Console.Write("Транслит - " + libraryOfNames[collectionKey]);
                }
                else
                {
                    Console.WriteLine("Введённое имя - " + collectionKey + " отсутствует в базе");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    isContinueCycle = false;
                }
            }
        }
    }
}

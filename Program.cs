using System;
using System.Collections.Generic;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> collection = new Dictionary<string, string>();
            collection.Add("Вася", "Vasya");
            collection.Add("Коля", "Kolya");
            collection.Add("Дима", "Dima");
            collection.Add("Витя", "Vitya");
            collection.Add("Аня", "Anya");
            collection.Add("Таня", "Tanya");

            bool сontinue = true;

            while (сontinue)
            {
                Console.Clear();

                foreach (var str in collection)
                {
                    Console.WriteLine(" "+str.Key);
                }

                Console.Write("Введите имя - ");

                string collectionKey = Console.ReadLine();

                if (collection.ContainsKey(collectionKey))
                {
                    Console.Write("Транслит - " + collection[collectionKey]);
                }
                else
                {
                    Console.WriteLine("Введённое имя - " + collectionKey + " отсутствует в базе");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    сontinue = false;
                }
            }
        }
    }
}

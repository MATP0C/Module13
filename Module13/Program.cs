using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace Module13
{

    public class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            LinkedList<string> linkedList = new LinkedList<string>();


            string path = @"C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\Grob.txt";
            string text = File.ReadAllText(path);
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '?', '№', '‰', '(', '±', ')', '‡', '“', '”', '\t' };
            string[] words = text.Split(delimiterChars);


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i]);
            }

            stopWatch.Stop();
            Console.WriteLine($"Время вставки элементов в список: {stopWatch.ElapsedMilliseconds} миллисекунд");


            list.Clear();
            linkedList.Clear();


            stopWatch = new Stopwatch();
            stopWatch.Restart();


            for (int i = 0; i < words.Length; i++)
            {
                linkedList.AddLast(words[i]);
            }

            stopWatch.Stop();
            Console.WriteLine($"Время вставки элементов в связанный список: {stopWatch.ElapsedMilliseconds} миллисекунд");
        }
    }
}
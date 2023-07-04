using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\bogda\\OneDrive\\Рабочий стол\\C#\\Grob.txt";
            string text = File.ReadAllText(path);
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '?', '№', '‰', '(', '±', ')', '‡', '“', '”', '\t' };
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] words = text.Split(delimiterChars);

            foreach (string word in words)
                if (!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 1);
                }
                else
                {
                    int count = wordCount[word];
                    wordCount[word] = count + 1;
                }

            string[] top10Words = wordCount.OrderByDescending(x => x.Value).Take(10).Select(x => x.Key).ToArray();
            Console.WriteLine($"Топ-10 самых часто повторяющихся слов:");
            for(int i = 0; i < top10Words.Length; i++)
            {
                Console.WriteLine("{0} : {1}", top10Words[i], wordCount[top10Words[i]]);
            }
            Console.ReadKey();
        }
    }
}
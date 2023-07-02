using System.Collections.Generic;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите текст:");
                var sentence = Console.ReadLine();
                var characters = sentence.ToCharArray();
                var symbols = new HashSet<char>();
                foreach (var symbol in characters)
                    symbols.Add(symbol);
                Console.WriteLine(symbols.Count);

                var signs = new[] { ',', ' ', '.' };
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                bool containsNumbers = symbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
            }
        }
    }
}
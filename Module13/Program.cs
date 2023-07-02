using System.Collections.Generic;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            var characters = sentence.ToCharArray();

            var symbols = new HashSet<char>();

            foreach (var symbol in characters)
                symbols.Add(symbol);

            Console.WriteLine(symbols.Count);
        }
    }
}
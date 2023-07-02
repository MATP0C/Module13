using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "Pop":
                        {
                            words.TryPop(out string popResult);
                            break;
                        }
                    
                    case "Peek":
                        {
                            words.TryPeek(out string peekResult);
                            break;
                        }
                        words.Push(input);
                        break;
                }


                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}
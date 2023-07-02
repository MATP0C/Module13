﻿using System;
using System.Collections.Concurrent;
using System.Threading;

namespace StackTest
{
    class Program
    {
        public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();

                if(input == "peek")
                {
                    if(words.TryPeek(out var elem))
                    {
                        Console.WriteLine(elem);
                    }
                    else
                    {
                        words.Enqueue(input);
                    }
                }
            }
        }

        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }
}
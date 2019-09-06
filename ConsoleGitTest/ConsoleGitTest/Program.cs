﻿using Microsoft.CognitiveServices.Speech;
using System;

namespace ConsoleGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SpeechConfig.FromSubscription("YourSubscriptionKey", "YourServiceRegion");
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

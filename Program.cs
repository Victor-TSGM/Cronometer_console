﻿using System;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Start();


        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
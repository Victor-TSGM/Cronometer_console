using System;
using System.Runtime.Intrinsics.Arm;
using Microsoft.VisualBasic;


static void Menu()
{
    Console.Clear();
    Console.WriteLine("[S]: Segundos");
    Console.WriteLine("[M]: Minutos");
    Console.WriteLine("[0]: Sair");
    Console.WriteLine("Quanto tempo?");

    string data = Console.ReadLine().ToLower();

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    if (time == 0)
    {
        System.Environment.Exit(0);
    }

    if(type == 's'){
        Start(time);
    }else if(type == 'm'){
        Start(time * 60);
    }
}

static void Start(int time)
{
    int currentTime = 0;



    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(100);
        Console.Clear();
        Console.WriteLine("Stopwatch finalizado");
    }
}


Menu();

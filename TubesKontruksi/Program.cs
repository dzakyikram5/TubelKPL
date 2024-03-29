﻿using System;
using System.Timers;

public class ConsoleApp1
{
    private static System.Timers.Timer aTimer;

    public static void Main()
    {
        SetTimer();

        Console.WriteLine("\nPress the Enter key to exit the application...\n");
        Console.WriteLine("Mulai pukul : {0:HH:mm:ss}", DateTime.Now);
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("Selesai...");
    }

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(1000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("{0:HH:mm:ss}",
                          e.SignalTime);
    }
}
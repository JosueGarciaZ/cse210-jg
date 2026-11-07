using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void BreathIn()
    {
        Console.Write("Breathe in... ");
        ShowCountDown(4);
        Console.WriteLine();
    }

    public void BreathOut()
    {
        Console.Write("Now breathe out... ");
        ShowCountDown(6);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void RunBreath()
    {
        Prologue();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            BreathIn();
            BreathOut();
        }

        Epilogue();
    }
}
using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Run()
    {
        DisplayStartMessage();
        int time = 0;
        while (time < GetDuration())
        {
            //added beep so user knows when to breathe in
            Console.Beep();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            time += 4;
            if (time >= GetDuration()) break;

            //added beep so user knows when to breathe out
            Console.Beep();
            Console.Write("Breathe Out...");
            ShowCountDown(7);
            time += 7;
        }
        DisplayEndingMessage();
    }
}
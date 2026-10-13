using System;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Mood: {_mood}/10");
        Console.WriteLine(_response);
        Console.WriteLine("");
    }
}
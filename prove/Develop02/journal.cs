using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public List<String> _prompts = new List<string>
    {
        "What was the most interesting thing that happended today?",
        "What was the strongest emotion I felt today?",
        "Who did I met today?",
        "What did I learn today?",
        "What was the most valuable lesson that somebody taught me today?"
    };

    public void Input()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Console.Write("How would you rate your day from 1 to 10? ");
        string mood = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._prompt = prompt;
        entry._response = response;
        entry._mood = mood;

        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}~|~{entry._mood}");
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
        Console.WriteLine("That file was not found.");
        return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }
    }
}
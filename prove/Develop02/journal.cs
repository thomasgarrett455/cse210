using System;
using System.Collections.Generic;
using System.IO;
using Journalentry;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("--------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._prompt}");
                writer.WriteLine($"Entry: {entry._entry}");
                writer.WriteLine("-----");
            }
        }
        Console.WriteLine($"Entries saved to {filename}");
    }

    public List<JournalEntry> GetEntries()
    {
        return _entries;
    }

    public void LoadFromFile(string file_name)
    {
        if (!File.Exists(file_name))
        {
            Console.WriteLine("File not Found");
            return;
        }
        _entries.Clear();

        string[] lines = File.ReadAllLines(file_name);
    string date = "";
    string prompt = "";
    string entry = "";

    foreach (string line in lines)
    {
        if (line.StartsWith("Date: "))
        {
            date = line.Substring(6);
        }
        else if (line.StartsWith("Prompt: "))
        {
            prompt = line.Substring(8);
        }
        else if (line.StartsWith("Entry: "))
        {
            entry = line.Substring(7);
        }
        else if (line == "-----")
        {
            var loadedEntry = new JournalEntry(prompt, entry)
            {
                _date = date 
            };
            _entries.Add(loadedEntry);
        }
    }

    }
}
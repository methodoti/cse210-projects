using System;
using System.IO;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        LoadFromFile();
    }

    public void LoadFromFile()
    {
        string file = "scripture.csv";
        string _separator = "\"";
        int counter = 0;
        string[] lines = System.IO.File.ReadAllLines(file);
        // _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(_separator);
            // Entry fileLoadEntry = new Entry();
            if (counter != 0)
            {
                string book = parts[1];
                int chapter = int.Parse(parts[3]);
                int verse = int.Parse(parts[5]);
                int endVerse = int.Parse(parts[7]);
                string text = parts[9];
                // fileLoadEntry._date = parts[1];
                // fileLoadEntry._promptText = parts[3];
                // fileLoadEntry._entryText = parts[5];
                // AddEntry(fileLoadEntry);
                Reference reference = new Reference(book, chapter, verse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                _scriptures.Add(scripture);
            }
            counter += 1;
        }
    }

    // public Scripture GetRandomScripture()
    // {

    // }
}
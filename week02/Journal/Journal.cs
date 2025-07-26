using System.IO;

public class Journal
{
    public List<Entry> _entries; 

    public Journal() 
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    { 
        _entries.Add(newEntry); 
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        file += ".csv";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            string _separator = "\"";
            outputFile.WriteLine($"{_separator}Date{_separator},{_separator}Prompt Text{_separator},{_separator}Entry Text{_separator}");

            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{_separator}{e._date}{_separator},{_separator}{e._promptText}{_separator},{_separator}{e._entryText}{_separator}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        file += ".csv";
        string _separator = "\"";
        int counter = 0;
        string[] lines = System.IO.File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(_separator);
            Entry fileLoadEntry = new Entry();
            if (counter != 0)
            {
                fileLoadEntry._date = parts[1];
                fileLoadEntry._promptText = parts[3];
                fileLoadEntry._entryText = parts[5];
                AddEntry(fileLoadEntry);
            }
            counter += 1;
        }
    }
}
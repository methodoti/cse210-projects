using System;
using System.Diagnostics.Contracts;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference() //just for now, with no arguments. I don't know how to connect to Scriptures yet
    {

    }
    public Reference(string book, int chapter, int verse)
    {

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }
}
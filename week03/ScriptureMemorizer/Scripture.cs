using System;

public class Scripture
{
    private Reference _reference = new Reference();

    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {

    }

    public void HideRandomWords(int numbertoHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
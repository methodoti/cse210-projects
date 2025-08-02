using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _randomGenerator = new Random();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numbertoHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        for (int i = 0; i < numbertoHide; i++)
        {
            if (visibleWords.Count == 0)
            {

                break;
            }

            int _randomIndex = _randomGenerator.Next(0, visibleWords.Count());
            visibleWords[_randomIndex].Hide();
            visibleWords.Remove(visibleWords[_randomIndex]);
        }
    }

    public string GetDisplayText()
    {
        string returnText = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
            returnText = returnText + w.GetDisplayText() + " ";
        }
        return returnText.Remove(returnText.Length -1);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;  
    }
}
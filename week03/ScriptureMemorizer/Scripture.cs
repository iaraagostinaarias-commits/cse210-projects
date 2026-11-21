using System.Runtime.InteropServices;

public class Scripture
{
    // Variables
    private Reference _reference;

    private List<Word> _word = new List<Word>();

    // Constructor
    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;

        List<string> verseToList = new List<string>(verseText.Split(" ").ToList());

        foreach (string item in verseToList)
        {
            Word word = new Word(item);
            _word.Add(word);
        }
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        int hiddenWords = 0;
        int visibleWords = 0;
        foreach (Word word in _word)
        {
            if (word.IsHidden() == false)
            {
                visibleWords += 1;
            }
        }

        if (visibleWords < numberToHide)
        {
            numberToHide = visibleWords;
        }

        Random takeRandomWord = new Random();

        while (hiddenWords < numberToHide)
        {
            int randomIndex = takeRandomWord.Next(_word.Count);
            Word theRandomWord = _word[randomIndex];
            bool currentStatus = theRandomWord.IsHidden();

            if (currentStatus == false)
            {
                theRandomWord.Hide();
                hiddenWords += 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _word)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + ": " + displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            bool status;
            status = word.IsHidden();

            if (status != true)
            {
                return false;
            }
        }
        return true;
    }
}

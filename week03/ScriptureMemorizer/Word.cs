public class Word
{
    // Variables
    private string _text;

    private bool _wordStatus;

    // Constructor
    public Word(string word)
    {
        _text = word;
        _wordStatus = false;
    }

    // Methods
    public void Hide()
    {
        _wordStatus = true;
    }

    // public void Show()
    // {
    //     Console.Write(_text);
    // }

    public bool IsHidden()
    {
        return _wordStatus;
    }

    public string HideToString()
    {
        int textLength = _text.Length;
        string hiddenWord = new string('_', textLength);
        return hiddenWord;
    }

    public string GetDisplayText()
    {
        if (_wordStatus == false)
        {
            return _text;
        }
        else
        {
            return HideToString();
        }
    }
}

/* I created a new method called HideToString to generate the undercores with the length of a word and returns it as a string and not as a result on the screen, and the Hide method will only change the status of the word. */
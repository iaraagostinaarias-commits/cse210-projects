public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public Random _randomPrompt = new Random();

    public string GetRandomPrompt()
    {
        int r = _randomPrompt.Next(_prompts.Count);
        string aPromt = _prompts[r];
        return aPromt;
    }
}

/* I wasn't quite sure how get a ramdom prompt, I knew I needed to use the Random Class we learned in week 01, but I didn't know how to apply it correctly to a list of strings. I searched in Strak Overflow and I found the approche I use in the code above. Here is the link to where I found this:
https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable  */

using System.Linq.Expressions;
using System.Net;

public class Word
{   
    private string _text;
    private string hide;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide(string word, List<string>clean, List<string>words)
    {
        int word_lengh = word.Length;
        hide = string.Concat(Enumerable.Repeat("_", word_lengh));
        int index = words.IndexOf(word);
        words[index] = hide;
        clean.Remove(word);   
    }


}
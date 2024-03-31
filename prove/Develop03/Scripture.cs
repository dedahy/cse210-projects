using System.Linq.Expressions;
using System.Net;

public class Scripture
{
    private string _text;

    public List<string> text = new List<string>();

    public Scripture(string text)
    {
        _text = text;
    }
    public string Text(int refer)
    {

        return text[refer];
    }

    
   public string word_array(List<string> list)
    {
        Random New_generate = new Random();
        int number = New_generate.Next(0, list.Count());
        string word = list.ElementAt(number);

        return word;
    }
    public int i(int[]numbers)
    {        
        Random New_generate = new Random();
        int number = New_generate.Next(0, numbers.Length);
        int i = numbers.ElementAt(number);

        return i;
    }

}

using System.Linq.Expressions;
using System.Net;
public class Reference
{
    private string _reference;
    public List<string> references = new List<string>();

    public Reference(string book, int chapter, int StartVerse, int EndVerse)
    {
        _reference = book + chapter + StartVerse + EndVerse;
    }

    public string GetDisplayText()
    {
        Scripture s = new Scripture("scripture");
        
        int[]a = [0,1,2,3];
        _reference = references[s.i(a)];

        return _reference;
    }
    

}
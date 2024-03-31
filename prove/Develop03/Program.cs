using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture("scripture");
        
        string book = "";
        int chapter = 0;
        int StartVerse = 0;
        int EndVerse = 0;

        Reference rf = new Reference(book, chapter, StartVerse, EndVerse);

        Word w = new Word("");

        s.text.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        s.text.Add("I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        s.text.Add("And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God");
        s.text.Add("Be ye therefore perfect, even as your Father which is in heaven is perfect.");

        rf.references.Add("John 3:16");
        rf.references.Add("Mosiah 2:41 And moreover");
        rf.references.Add("Doctrine and Covenants 14:7");
        rf.references.Add("Matthew 5:48");


        List<string> words = new List<string>();
        List<string> clean = new List<string>();
        List<int> iii = new List<int>();

        int[] numbers = [0,1,2,3];
        string refer = rf.GetDisplayText();
        int indexx = rf.references.IndexOf(refer);
        string sentence = s.Text(indexx);
        string scripture = $"{refer} {sentence}";
        
        string[] text = sentence.Split(" ");

        foreach(string word in text)
        {
            words.Add(word);
        }
        clean.AddRange(words);

        Console.WriteLine(scripture);
        Console.WriteLine();

        string decision = "";


        while(decision != "quit")
        {
            Console.WriteLine("\n\nPlease enter to 'continue' or type 'quit' to finish:");

            decision = Console.ReadLine().ToLower();

            Console.Clear();

            if(clean.Count() == 0)
            {
                Environment.Exit(0);
            }  

            int a = 0;
            int[] repeat = [1,2,3];
            int z = s.i(repeat);
            if(z > clean.Count())
            {
                iii.Add(clean.Count());
            }
            else
            {
             iii.Add(z);
            }
            int az = iii[0];

            while(a < az)
            {
                string word = s.word_array(words);

                if(word.Contains("_"))
                {
                    string new_word = s.word_array(clean);
                    w.Hide(new_word, clean, words);                    
                }

                else
                {
                    w.Hide(word, clean, words);                    
                }

                   a++;
            }

                iii.Clear();
                Console.WriteLine();                
                Console.Write(refer);
            foreach(string wordd in words)
            {                
                Console.Write($" {wordd.Trim()}");
            }            
             
        }
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
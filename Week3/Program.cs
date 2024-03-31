List<string> text = new List<string>();        

        text.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        text.Add("I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        text.Add("And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God");
        text.Add("Be ye therefore perfect, even as your Father which is in heaven is perfect.");


for (int i = 0; i < 2; i++)
{
    Random rnd = new Random();
    int number = rnd.Next(0, text.Count());
    string word = text.ElementAt(number);

    Console.WriteLine(word);
}


/*

        List<string> refernce = new List<string>();
        List<string> text = new List<string>();

        List<string> scripture = new List<string>();

        int[] numbers = [0,1,2,3];

        refernce.Add("John 3:16");
        refernce.Add("Mosiah 2:41 And moreover");
        refernce.Add("Doctrine and Covenants 14:7");
        refernce.Add("Matthew 5:48");

        text.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        text.Add("I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        text.Add("And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God");
        text.Add("Be ye therefore perfect, even as your Father which is in heaven is perfect.");

        Random New_generate = new Random();

        int number = New_generate.Next(0, numbers.Length);

        int i = numbers.ElementAt(number);

        Console.WriteLine($"{refernce[i]} {text[i]}");





/*
string phrase = "The quick brown fox jumps over fox the fence";

Console.WriteLine(phrase);

char[] phraseAsChars = phrase.ToCharArray();
int animalIndex = phrase.IndexOf("fox");

if (animalIndex != -1)
{
    phraseAsChars[animalIndex++] = 'c';
    phraseAsChars[animalIndex++] = 'a';
    phraseAsChars[animalIndex] = 't';
}

string updatedPhrase = new string(phraseAsChars);
Console.WriteLine(updatedPhrase);


/*string a = string.Concat(Enumerable.Repeat("a", 2));

Console.WriteLine(a);

/*static List<string> GetSrcipture()
    {
        List<string> _promts = new List<string>();

        _promts.Add("John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _promts.Add("Mosiah 2:41 And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        _promts.Add("Doctrine and Covenants 14:7 And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God");
        _promts.Add("Matthew 5:48 Be ye therefore perfect, even as your Father which is in heaven is perfect.");

        return _promts;chro
    }

    void Run()
    {
        Random randomGenerator = new Random();
        int someRandomNumber = randomGenerator.Next(0, GetSrcipture().Count());
        string prompt = GetSrcipture().ElementAt(someRandomNumber);
        Console.Write(prompt);
    }



/*string authors = "Mahesh Beniwal, Neel Beniwal, Raj Beniwal, Dinesh Beniwal";
Console.WriteLine($"Authors with last names: {authors}");
// Remove all Beniwal with space and remove space with empty string
Random one = new Random();

string[] word = authors.Split(" ");

int za = one.Next(0, word.Length);

string let = one.Next(0, authors.Count())


string firstNames = authors.Replace("Beniwal", " _");
Console.WriteLine($"Authors without last names: {firstNames}");

/*string text = "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

Console.WriteLine(text);
//Console.WriteLine(text.Count());

string[] words = text.Split(" ");

int wordcount = words.Length;

Console.WriteLine(wordcount);

Random R = new Random();

int rad = R.Next(0, words.Length);

string e = words.ElementAt(rad);

Console.ReadKey();

Console.Clear();

Console.WriteLine(e);

*/

//Random randomGenerator = new Random();
//int someRandomNumber = randomGenerator.Next(0, text.Count());
//Console.Write(""); 
//string le = text.ElementAt(someRandomNumber);
//
//Console.Write(le);


/*

// This will start by displaying "AAA" and waiting for the user to press the enter key
Console.WriteLine("AAA");
Console.ReadLine();

// This will clear the console
Console.ReadKey();
Console.Clear();

// This will show "BBB" in the console where "AAA" used to be
Console.WriteLine("BBB");

*/
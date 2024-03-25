        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string  symbol = animationStrings[i];
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }

/*DateTime currentTime = DateTime.Now;
DateTime future = currentTime.AddSeconds(2);
while (future > currentTime)
{
    Console.WriteLine("sIRA");
    currentTime = DateTime.Now;
  // future = currentTime.AddSeconds(5);
}
/*for(int e = 1; e>0; e--)
{
    Console.WriteLine("Sira");
}



/*

double a = 2.3;
Console.WriteLine($"{a}, {Math.Round(a, MidpointRounding.AwayFromZero)}");
Console.WriteLine($"{a}, {Math.Round(a, MidpointRounding.AwayFromZero).GetType()}");
int b = 0;
b = (int)a;
Console.WriteLine(b);

/*List<string> grocery = new List<string>();

grocery.Add("Vary");
grocery.Add("Menaka");
grocery.Add("Sira Mamy");

Console.WriteLine(grocery[0]);


/*List<string> animationStrings = new List<string>();
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");
animationStrings.Add("|");
animationStrings.Add("/");
animationStrings.Add("-");
animationStrings.Add("\\");

foreach(string i in animationStrings)
{
    Console.Write(i);
    Thread.Sleep(1000);
    Console.Write("\b \b");
}

*/
/*int i=0;

while(i<5)
{
    Console.WriteLine("Love");
    i++;
}
10s
5sc each

2*1000

*/
/*
Console.Write("Time starts");
Thread.Sleep(2000);


Console.Write("How many seconds:");
int seconds = int.Parse(Console.ReadLine());

int rep = 0;
int csm = 0;
int csmc = 0;
int csmcs = 0;
csm = seconds * 1000 / 32;

*/

/*
if(seconds<=10)
{
    rep = 1;
    csm = seconds * 1000 / 8;
    csmc = seconds * 1000 / 10;
}   
else if(seconds<20)
{
    rep = 2;
    csm = seconds * 1000 / 16;
    csmc = seconds * 1000 / 10;
}
else
{
    rep = 4;
    csm = seconds * 1000 / 32;
    csmc = seconds * 1000 / 10;
}
*/

/*
int count = 0;
while(count < 2)
{
    Console.Write($"Breathe in...");
    
    for(int e = 4; e>0; e--)
    {
        Console.Write(e);
        Thread.Sleep(700);
        Console.Write("\b \b");
    }
    Console.WriteLine();
    Console.Write($"Breathe out...");
    for(int e = 6; e>0; e--)
    {
        Console.Write(e);
        Thread.Sleep(700);
        Console.Write("\b \b");
    }
    Console.WriteLine("\n");
    
    Thread.Sleep(csm);
    Console.Write("\b \b");
    count++;
}

*/



/*

for(int e = 5; e>0; e--)
    {
//        Console.Write(e);
        Console.Write($"Breathe in...{e}");
        Thread.Sleep(1200);
        Console.Write("\b \b");
    }

int re;

while(re < 4) //int i = cam; i>0; i++
{
    for(int e = 4; e>0; e--)
    {
        Thread.Sleep(3600);
        Console.Write("\b \b");
        Console.WriteLine($"Braethe in ...{e}");
        Console.WriteLine($"Breathe out...{e=6}");
    }
    Console.WriteLine();
    re++;   
}
*/

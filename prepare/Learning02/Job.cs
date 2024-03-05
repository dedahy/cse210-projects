using System;

public class Job
{
        public string _jobTitle = "Software Engineer";
        public string _company = "Microsoft";
        public int _startYear = 2019;
        public int _endYear = 2022;

        public void display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
        }
}


//public class resume
//{
//    static void Main(string[] args)
//    {
//        string _fname = "John";
//        string _lname = "Smith";
//        string jobs = "Customer service";
//    }
//    
//}
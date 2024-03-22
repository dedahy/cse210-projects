/*
public class Person
{
    public string GetName()
    {   
        return "Joseph";
    }
}*/
public class Person
{
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;

    }

    public string GetName()
    {
        return _name + " " + _age;
    }
}
/*
public class Student : Person
{
    public string GetNumber()
    {
        return "0123456789";
    }
}
*/

public class Student : Person
{
    private string _number;
    private string _money;

    public Student(string name, int age, string number, string money) : base(name, age)
    {
        _number = number;
        _money = money;
    }

    public string GetNumber()
    {
        return _number + " " + _money;
    }

}
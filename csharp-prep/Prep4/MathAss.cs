
public class MathAssignment:Assignment
{
    
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string top, string textbook, string problems) : base(name, top)
    {
        _textbookSection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string studentName = GetStudentName();
        return $"Section {_textbookSection}, Problem {_problems} by {studentName}";
    }
}
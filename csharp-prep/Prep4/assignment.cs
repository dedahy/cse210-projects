
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string top)
    {
      _studentName = name;
      _topic = top;
    }

   public string GetTopic()
    {
        return _topic;
    }
   public string GetStudentName()
   {
      return _studentName;
   }
    public string GetSummary()
    {
      return _studentName + " " + _topic;
    }
}
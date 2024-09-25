

namespace ConsoleApp29;

public class Teacher
{
    public int TeacherId { get; set; }
    public string Name { get; set; }

  
    public ICollection<Group> Groups { get; set; }
}

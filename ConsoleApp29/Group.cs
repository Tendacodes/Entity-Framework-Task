

namespace ConsoleApp29;

public class Group
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public int TeacherId { get; set; } 
    public Teacher Teacher { get; set; }
    public ICollection<Student> Students { get; set; }
}

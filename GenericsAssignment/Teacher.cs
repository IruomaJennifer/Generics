// See https://aka.ms/new-console-template for more information
public class Teacher : EntityBase
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }
   
}

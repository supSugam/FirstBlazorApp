namespace FirstBlazorApp.Data;

public class Student
{
    public string FullName { get; set; }
public string PhoneNumber { get; set; }
public int Semester { get; set; }
public Guid Guid { get; set; }
}

internal class AllStudentsList
{
    public List<Student> AllStudents { get; set; }
    public AllStudentsList()
    {
        this.AllStudents = new();
    }
}
namespace Lab4Web.Data;

public class Course
{
    public Guid Id { get; set; }
    public string CourseName { get; set; }
    public int FacultyId { get; set; }

    public Course(Guid id, string courseName, int facultyId)
    {
        Id = id;
        CourseName = courseName;
        FacultyId = facultyId;
    }
}
namespace Lab4Web.Data;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
    public string SerialNumber { get; set; } //Ex: 322210101RSL122220
    public string Faculty { get; set; }
    public int FacultyId { get; set; }
    

    public Student(Guid id, string name, int age, string nationality, string serialNumber, string faculty, int facultyId)
    {
        Id = id;
        Name = name;
        Age = age;
        Nationality = nationality;
        SerialNumber = serialNumber;
        Faculty = faculty;
        FacultyId = facultyId;
    }
}
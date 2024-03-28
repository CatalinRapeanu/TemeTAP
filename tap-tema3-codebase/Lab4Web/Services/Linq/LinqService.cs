using System.Collections;
using Lab4Web.Data;

public class LinqService : ILinqService
{
    public int Test1(int value)
    { 
        //Method-expression 
        return Data.Students.Count(student => student.Age >= value);
    }

    public IEnumerable<Student> Test2(string faculty)
    {
        //Query-expression
        //lista cu clauza where
        var query = from student in Data.Students where student.Faculty.Equals(faculty) select student;
        return query;
    }

    public IEnumerable<string> Test3()
    {
        //Query-expression
        //lista de stringuri doar cu o proprietate
        var query = from student in Data.Students select student.Name;
        return query;
    }

    public int Test4()
    {
        //Method-expression
        //cu nr de elemente
        return Data.Students.Count();
    }

    //join
    public IEnumerable<Student> Test5(string faculty)
    {
        var query = from student in Data.Students
            join course in Data.Courses on student.FacultyId equals course.FacultyId
            where student.Faculty.Equals(faculty)
            select student;
        return query;
    }

    //group
    public IEnumerable<IGrouping<string, Student>> Test6(string faculty)
    {
        var query = from student in Data.Students
            where student.Faculty.Equals(faculty)
            group student by student.Faculty
            into studentGroup
            select studentGroup;

        return query;
    }
}


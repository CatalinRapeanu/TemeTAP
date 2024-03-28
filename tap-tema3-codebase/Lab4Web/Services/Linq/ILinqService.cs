using Lab4Web.Data; 

public interface ILinqService
{
    int Test1(int value);

    IEnumerable<Student> Test2(string faculty);

    IEnumerable<string> Test3();

    int Test4();

    IEnumerable<Student> Test5(string faculty);

    IEnumerable<IGrouping<string, Student>> Test6(string faculty);
}


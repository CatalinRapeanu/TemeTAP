namespace Lab4Web.Data;

public static class Data
{
    public static List<Student> Students = new List<Student>();
    public static List<Course> Courses = new List<Course>();

    public static void AddStudent(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine("Student already exists.");
        }
        else
        {
            Students.Add(student);
            Console.WriteLine($"Student with id {student.Id} added.");
        }
    }

    public static void RemoveStudent(Guid studentId)
    {
        var student = Students.SingleOrDefault(x => x.Id == studentId);

        if (student != null)
        {
            Students.Remove(student);
            Console.WriteLine($"Student with id {student.Id} removed.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
    
    public static void AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            Console.WriteLine("Course already exists.");
        }
        else
        {
            Courses.Add(course);
            Console.WriteLine($"Course with id {course.Id} added.");
        }
    }
    
    public static void RemoveCourse(Guid courseId)
    {
        var course = Courses.SingleOrDefault(x => x.Id == courseId);

        if (course != null)
        {
            Courses.Remove(course);
            Console.WriteLine($"Course with id {course.Id} removed.");
        }
        else
        {
            Console.WriteLine("Course not found.");
        }
    }
 
    public static void AddData()
    {   
        Students.Clear();
        AddStudent(new Student(id: Guid.NewGuid(), name: "Mihai Baros", age: 21, nationality: "Romanian",
            serialNumber: "322210101RSL122220", faculty: "Mathematics", facultyId: 1));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Auras DeLaoras", age: 22, nationality: "Romanian",
            serialNumber: "311212121RSL123320", faculty: "Physics", facultyId: 2));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Mihaita Alesul", age: 20, nationality: "Romanian",
            serialNumber: "320200201RSL123441", faculty: "Mathematics", facultyId: 1));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Costi Forta", age: 19, nationality: "Romanian",
            serialNumber: "322210101RSL111110", faculty: "Mathematics", facultyId: 1));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Catalin Rapanon", age: 21, nationality: "Romanian",
            serialNumber: "325210101RSL122220", faculty: "Chemistry", facultyId: 3));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Andrei Magnificul", age: 20, nationality: "Romanian",
            serialNumber: "326910101RSL122220", faculty: "Law School", facultyId: 4));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Ion Ioan", age: 22, nationality: "Romanian",
            serialNumber: "302210101RSL122220", faculty: "Letters", facultyId: 5));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Popescu Ion", age: 18, nationality: "Romanian",
            serialNumber: "322219191RSL122220", faculty: "Mathematics", facultyId: 1));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Mirel Radu", age: 19, nationality: "Romanian",
            serialNumber: "322289781RSL122220", faculty: "Computer Science", facultyId: 6));
        AddStudent(new Student(id: Guid.NewGuid(), name: "Mircea Gicu", age: 21, nationality: "Romanian",
            serialNumber: "322210101RSL121111", faculty: "Mathematics", facultyId: 1));
        
        Courses.Clear();
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Algebra", facultyId: 1));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Geometrie", facultyId: 1));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Aritmetica", facultyId: 1));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Fizica nucleara", facultyId: 2));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Chimie organica", facultyId: 3));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Legi", facultyId: 4));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Literatura africana", facultyId: 5));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Inteligenta artificiala", facultyId: 6));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: ".NET", facultyId: 6));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Algebra", facultyId: 1));
        AddCourse(new Course(id: Guid.NewGuid(), courseName: "Algebra", facultyId: 1));
    }
    
}
List<Student> students = new();

int studentNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < studentNumber; i++)
{
    string[] input = Console.ReadLine()
        .Split(", ",StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    int age = int.Parse(input[1]);

    Student student = new Student();
    student.Name = name;
    student.Age = age;  
    students.Add(student);
}

string filterType=  Console.ReadLine(); ;
int filterNumber =  int.Parse(Console.ReadLine());

Func<Student, int, bool> filter = FilterGenerator(filterType);

students = students
    .Where(student => filter(student,filterNumber))
    .ToList(); 


//students = students
string format = Console.ReadLine();
Action<Student> printer = PrinterGenerator(format);

students.ForEach(student => printer(student));

Action<Student> PrinterGenerator(string format)
{
    if (format == "name age")
    {
        return s => Console.WriteLine($"{s.Name} - {s.Age}");
    }
    if (format == "name")
    {
        return s => Console.WriteLine($"{s.Name}");
    }
    if (format == "age")
    {
        return s => Console.WriteLine($"{s.Age}");
    }

    return null;

}
Func<Student, int, bool> FilterGenerator(string filterType)
{
    Func<Student, int, bool> filter = null;
    if (filterType == "older")
    {
        filter = (student, number) => student.Age > number;
    }

    if (filterType == "younger")
    {
        filter = (student, number) => student.Age < number;
    }
    return filter;
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
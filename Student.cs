class Student : User
{
    public Course Course { get; set; }
    public List<Discipline> Disciplines { get; set; }

    public Student(string name, Course course, List<Discipline> disciplines)
    {
        Name = name;
        Course = course;
        Disciplines = disciplines;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Student: {Name}, Course: {Course.Name}, Disciplines: {string.Join(", ", Disciplines.Select(d => d.Name))}");
    }
}
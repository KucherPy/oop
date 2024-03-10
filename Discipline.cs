class Discipline
{
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    public Discipline(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void GetInfo()
    {
        Console.WriteLine($"Discipline: {Name}, Teacher: {Teacher.Name}, Number of Students: {Students.Count}");
    }
}

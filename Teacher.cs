class Teacher : User
{
    public List<Discipline> Disciplines { get; set; }

    public Teacher(string name, List<Discipline> disciplines)
    {
        Name = name;
        Disciplines = disciplines;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Disciplines: {string.Join(", ", Disciplines.Select(d => d.Name))}");
    }
}

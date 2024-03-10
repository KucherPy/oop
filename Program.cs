using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Создание тестовых данных
        List<Course> courses = new List<Course>
        {
            new Course("Course1"),
            new Course("Course2"),
            new Course("Course3"),
            new Course("Course4")
        };

        List<Student> students = new List<Student>
        {
            new Student("Student1", courses[0], new List<Discipline> { new Discipline("Math"), new Discipline("Physics") }),
            new Student("Student2", courses[1], new List<Discipline> { new Discipline("Biology"), new Discipline("Chemistry") }),
            new Student("Student3", courses[2], new List<Discipline> { new Discipline("History"), new Discipline("Geography") }),
            new Student("Student4", courses[3], new List<Discipline> { new Discipline("Literature"), new Discipline("Art") }),
            new Student("Student5", courses[0], new List<Discipline> { new Discipline("Computer Science"), new Discipline("English") })
        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher("Teacher1", new List<Discipline> { new Discipline("Math"), new Discipline("Physics") }),
            new Teacher("Teacher2", new List<Discipline> { new Discipline("Biology"), new Discipline("Chemistry") }),
            new Teacher("Teacher3", new List<Discipline> { new Discipline("History"), new Discipline("Geography") }),
            new Teacher("Teacher4", new List<Discipline> { new Discipline("Literature"), new Discipline("Art") }),
            new Teacher("Teacher5", new List<Discipline> { new Discipline("Computer Science"), new Discipline("English") })
        };

        // Вывод информации о студентах и преподавателях
        foreach (var student in students)
        {
            student.GetInfo();
        }

        foreach (var teacher in teachers)
        {
            teacher.GetInfo();
        }
    }
}

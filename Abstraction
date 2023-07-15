using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int GradeLevel { get; set; }
    public List<string> Courses { get; set; }

    public Student(string name, int id, int gradeLevel)
    {
        Name = name;
        ID = id;
        GradeLevel = gradeLevel;
        Courses = new List<string>();
    }

    public void Enroll(string course)
    {
        Courses.Add(course);
        Console.WriteLine($"{Name} has enrolled in {course}.");
    }

    public double CalculateAverageGrade()
    {
        // Logic to calculate the average grade
        // ...

        double averageGrade = 0.0;
        // Calculate the average grade here

        return averageGrade;
    }
}

public class Class
{
    public List<Student> Students { get; set; }

    public Class()
    {
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        Console.WriteLine($"Added student: {student.Name}");
    }

    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
        Console.WriteLine($"Removed student: {student.Name}");
    }

    public void DisplayClassInfo()
    {
        Console.WriteLine("Class Information:");
        foreach (var student in Students)
        {
            Console.WriteLine($"Name: {student.Name}, ID: {student.ID}, Grade Level: {student.GradeLevel}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating students
        Student student1 = new Student("John Doe", 1, 10);
        Student student2 = new Student("Jane Smith", 2, 11);

        // Creating a class and adding students
        Class schoolClass = new Class();
        schoolClass.AddStudent(student1);
        schoolClass.AddStudent(student2);

        // Enrolling students in courses
        student1.Enroll("Math");
        student2.Enroll("Science");

        // Displaying class information
        schoolClass.DisplayClassInfo();
    }
}

using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {Name}");
    }
}

class Student : Person
{
    public int Grade;

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {Grade}학년");
    }
}
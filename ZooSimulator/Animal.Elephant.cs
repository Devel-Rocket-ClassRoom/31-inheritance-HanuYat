using System;

class Elephant : Animal
{
    public Elephant(string name, int age)
    {
        Name = name;
        Age = age;
        _sound = "뿌우!";
    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}
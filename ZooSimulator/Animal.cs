using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    protected string _sound;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}
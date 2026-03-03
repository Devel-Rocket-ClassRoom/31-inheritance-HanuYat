using System;

class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}
using System;

class Animal3
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹습니다.");
    }
}

class Dog3 : Animal3
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat2 : Animal3
{
    
}
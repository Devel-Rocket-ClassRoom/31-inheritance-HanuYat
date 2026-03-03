using System;

class Parent
{
    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
}

class Child : Parent
{
    public void Study()
    {
        Console.WriteLine("공부합니다.");
    }
}
using System;

class Parent3
{
    public int Value = 10;

    public void Show()
    {
        Console.WriteLine("Parent.Show()");
    }
}

class Child3 : Parent3
{
    public new int Value = 20;

    public new void Show()
    {
        Console.WriteLine("Child.Show()");
    }
}
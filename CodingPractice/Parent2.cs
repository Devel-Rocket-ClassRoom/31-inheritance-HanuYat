using System;

class Parent2
{
    private int _privateValue = 1;
    protected int _protectedValue = 2;
    public int PublicValue = 3;
}

class Child2 : Parent2
{
    public void ShowValues()
    {
        Console.WriteLine(_protectedValue);
        Console.WriteLine(PublicValue);
    }
}
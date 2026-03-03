using System;

class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public int CalculatePay()
    {
        return _baseSalary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[직원] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
    }
}

class Manager : Employee
{
    private int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, 5000000)
    {
        _bonus = bonus;
    }

    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"보너스: {_bonus:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}

class Developer : Employee
{
    private int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, 4000000)
    {
        _overtimeHours = overtimeHours;
    }

    public new int CalculatePay()
    {
        return _baseSalary + (_overtimeHours * 20000);
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}

class Intern : Employee
{
    public Intern(string name) : base(name, 1500000)
    {        
    }

    public new int CalculatePay()
    {
        return _baseSalary;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}
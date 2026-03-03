using System;

abstract class Vehicle
{
    public abstract void Start();
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("자동차 시동을 켭니다.");
    }
}
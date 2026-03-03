using System;

abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack();

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력: {Health}");
    }
}

class Warrior : GameCharacter
{
    public int Strength;

    public Warrior(string name, int strength) : base(name, 150)
    {
        Strength = strength;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다!");
    }
}

class Mage : GameCharacter
{
    public int MagicPower;

    public Mage(string name, int magicPower) : base(name, 80)
    {
        MagicPower = magicPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {MagicPower} 데미지를 입힙니다!");
    }
}
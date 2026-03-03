using System;

// README.md를 읽고 코드를 작성하세요.

Child child = new();
child.Greet();
child.Study();
Console.WriteLine();

Dog dog = new Dog { Name = "초코" };
Cat cat = new Cat { Name = "나비" };
dog.Eat();
dog.Bark();
cat.Eat();
cat.Meow();
Console.WriteLine();

Product product = new Product();
Console.WriteLine(product.ToString());
Console.WriteLine(product.GetType());
Console.WriteLine();

Child2 child2 = new Child2();
child2.ShowValues();
Console.WriteLine(child2.PublicValue);
Console.WriteLine();

Manager manager = new Manager();
manager.ShowInfo();
Console.WriteLine();

Student student = new Student("홍길동", 3);
Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");
Console.WriteLine();

Dog2 dog2 = new();
Console.WriteLine();

Dog3 dog3 = new Dog3 { Name = "멍멍이" };
Animal3 animal3 = dog3;
animal3.Eat();

Dog3 dog4 = (Dog3)animal3;
dog3.Bark();

if (animal3 is Dog3)
{
    Dog3 dog5 = (Dog3)animal3;
    dog5.Bark();
}

if (animal3 is Dog3 dog6)
{
    dog6.Bark();
}

Animal3 animal4 = new Cat2 { Name = "야옹이" };
Dog3 dog7 = animal4 as Dog3;

if (dog7 != null)
{
    dog7.Bark();
}

else
{
    Console.WriteLine("Dog 타입이 아닙니다.");
}
Console.WriteLine();

Asset[] assets = new Asset[3];
assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
assets[1] = new House { Name = "아파트", Mortgage = 500000 };
assets[2] = new Stock { Name = "SK하이닉스", Shares= 150 };

foreach (Asset asset in assets)
{
    Console.WriteLine(asset.Name);
}
Console.WriteLine();

Shape rect = new Rectangle { Name = "사각형", Width =  10, Height = 5 };
Shape circle = new Circle { Name = "원", Radius = 3 };

Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");
Console.WriteLine();

Vehicle car = new Car();
car.Start();
car.Stop();
Console.WriteLine();

FinalClass FC = new FinalClass();
FC.Display();
Console.WriteLine();

Child3 child3 = new Child3();
Parent3 parent3 = child3;

Console.WriteLine($"child3.Value: {child3.Value}");
Console.WriteLine($"parent3.Value: {parent3.Value}");
child3.Show();
parent3.Show();
Console.WriteLine();

Dog8 dog8 = new Dog8();

Console.WriteLine(dog8 is Animal4);
Console.WriteLine(dog8 is Dog8);
Console.WriteLine(dog8 is Cat8);
Console.WriteLine();

GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서", 25),
    new Mage("멀린", 40),
    new Warrior("란슬롯", 30)
};

foreach (GameCharacter character in characters)
{
    character.ShowStatus();
    character.Attack();
    Console.WriteLine();
}

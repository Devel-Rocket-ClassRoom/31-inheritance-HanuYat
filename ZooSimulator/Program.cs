using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===\n");

Console.WriteLine("[동물 정보]");

Lion lion = new Lion("시바", 5);
Elephant elephant = new Elephant("덤보", 10);
Penguin penguin = new Penguin("뽀로로", 3);
lion.DisplayInfo();
elephant.DisplayInfo();
penguin.DisplayInfo();
Console.WriteLine();

Console.WriteLine("[동물 소리]");
lion.MakeSound();
elephant.MakeSound();
penguin.MakeSound();
Console.WriteLine();

Console.WriteLine("[동물 행동]");
lion.Eat();
lion.Hunt();
elephant.Eat();
elephant.SprayWater();
penguin.Eat();
penguin.Swim();
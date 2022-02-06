//Задача 12: Удалить вторую цифру трёхзначного числа.

Console.Clear(); 
Console.WriteLine("введите трех значное чилсло: "); 
int num = int.Parse(Console.ReadLine()); 
int a = num / 100; 
int b = num % 10;
int c = a * 10 + b;
Console.WriteLine (c);
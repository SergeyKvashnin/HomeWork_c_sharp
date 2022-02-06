// Показать вторую цифру трёхзначного числа.

Console.Clear();
Console.WriteLine("введите трех значное чилсло: ");
int num = int.Parse(Console.ReadLine());
int n = num / 10 % 10;
Console.WriteLine("Второе число: " + n);

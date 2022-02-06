// Найти третью цифру числа или сообщить, что её нет

Console.Clear(); 
Console.WriteLine("введите чилсло: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("третьего числа нет");
    return;
}
while (num > 999)
{
    num = num / 10;  
}
if (num < 1000)
{
    int e = num % 10;
    Console.WriteLine("третье число " + e);
}
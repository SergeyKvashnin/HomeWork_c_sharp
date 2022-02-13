// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.WriteLine("Задайте номер четверти: ");
int chetvert = int.Parse(Console.ReadLine());

if (chetvert == 1 )    //(x > 0 && y > 0)
{
    Console.WriteLine("первая четверть");
    Console.WriteLine("диапазон: х от 0 до ∞ ");
    Console.WriteLine("диапазон: y от 0 до ∞");
}
else if (chetvert == 2)     //(x < 0 && y > 0)
{
    Console.WriteLine("вторая четверть");
    Console.WriteLine("диапазон: х от 0 до - ∞");
    Console.WriteLine("диапазон: y от 0 до ∞");
}
else if (chetvert == 3)    //(x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть");
    Console.WriteLine("диапазон: х от 0 до ∞");
    Console.WriteLine("диапазон: y от 0 до - ∞");
}
else if (chetvert == 4)   //(x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть.");
    Console.WriteLine("диапазон: х от 0 до - ∞");
    Console.WriteLine("диапазон: y от 0 до - ∞");
}
else 
{
    Console.WriteLine("четверть введена не верна");
}

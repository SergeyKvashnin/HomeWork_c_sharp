// Найти кубы чисел от 1 до N


Console.Clear();
Console.Write("Введите число:  ");
int n = int.Parse(Console.ReadLine());
Console.Write("Число:   ");
for (int i = 1; i <= n; i++)
{
    Console.Write( i + "\t");
}
Console.WriteLine();
Console.Write("Куб:     " );
for (int i = 1; i <= n; i++)
{
    Console.Write(i*i*i + "\t");
}
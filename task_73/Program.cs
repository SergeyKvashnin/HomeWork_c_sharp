//Задача 73 : Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
//Например, для N = 50, M получается 6

Console.Clear();
Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());
int group = 0;
for (int i = 1; i <= num; i++)
{
    if (i == Math.Pow(2, group))
{
Console.WriteLine();
group++;
Console.Write($"Группа {group}: ");
}
Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine();
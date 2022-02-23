// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int [,] array = new int [n,m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next(0, 60);
        Console.Write(array[i,j]+ "\t ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"Число {num} находится на: строка: {i}, столбец: {j}");
            }
        }
    }
Console.WriteLine("В данном массиве введенное число не найдено");
//Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.

int n = new Random().Next(3, 7);
int m = new Random().Next(3, 7);
double[,] mass = new double[n, m];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().NextDouble() * (20);
        Console.Write(mass[i, j] + "  ");
    }
    Console.WriteLine();
}
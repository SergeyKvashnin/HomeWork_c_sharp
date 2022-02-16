// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
double [] mass = new double [123]; 

for (int i =0; i <mass.Length; i++)
{
    mass[i] = new Random().Next(10, 1300);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

double min = mass[0];
double max = mass[0];
for (int i =0; i <mass.Length; i++)
{
    if (mass[i]>max) max = mass[i];
    if (mass[i]<min) min = mass[i];
}
Console.Write("максимальная: " + max);
Console.WriteLine();
Console.Write("минимальная: " + min);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным = {0}", max - min);
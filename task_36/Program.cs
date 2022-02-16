// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
Console.Clear();
int[] mass = new int[10];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(99, 899);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

int chet = 0;
int nechet= 0 ;
for (int i = 0; i < mass.Length; i++)
{
    if ( mass[i]%2==1)
    {
        nechet++;
    }
    
    else//if (mass[i]%2==0)
    {
        chet++;
    }
}
Console.Write($"четные чилсла {chet} раз");
Console.WriteLine();
Console.Write($"не четные чилсла {nechet} раз");

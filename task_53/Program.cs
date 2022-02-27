//Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear(); 
Console.Write("Введите количество строк: "); 
int n = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов: "); 
int m = int.Parse(Console.ReadLine()); 
int[,] mass = new int[n, m]; 
 
for (int i = 0; i < mass.GetLength(0); i++) 
{ 
    for (int j = 0; j < mass.GetLength(1); j++) 
    { 
        mass[i, j] = new Random().Next(0, 10); 
        Console.Write(mass[i, j] + "\t "); 
 
    } 
    Console.WriteLine(); 
} 
Console.WriteLine("Введите число: "); 
bool result = false;
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < mass.GetLength(0); i++) 
{ 
    for (int j = 0; j < mass.GetLength(1); j++) 
    { 
            if (mass[i, j] == num)
            {
                Console.WriteLine($"Число {num} находится на: строка: {i}, столбец: {j}"); 
                result=true;
            }
    }  
} 
if(!result)
    {
        Console.WriteLine($"Число {num} нет в массиве");
    }
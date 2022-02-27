// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

Console.Clear();
Console.WriteLine("Введите Z: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X: ");
int c = int.Parse(Console.ReadLine());
Random random = new Random();
int[,,] myarray = new int[a, b, c];

for (int z = 0; z < myarray.GetLength(0); z++)
{
    for (int y = 0; y < myarray.GetLength(1); y++)
    {
        for (int x = 0; x < myarray.GetLength(2); x++)
        {
            myarray[z, y, x] = random.Next(10, 100);
        }
    }
}

for (int z = 0; z < myarray.GetLength(0); z++)
{
    Console.WriteLine();
    for (int y = 0; y < myarray.GetLength(1); y++)
    {
        for (int x = 0; x < myarray.GetLength(2); x++)
        {
            Console.Write(myarray[z, y, x] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("================================");
}
Console.WriteLine();


for (int z = 0; z < myarray.GetLength(0); z++)
{
    Console.WriteLine();
    for (int y = 0; y < myarray.GetLength(1); y++)
    {
        for (int x = 0; x < myarray.GetLength(2); x++)
        {
            Console.Write(myarray[z, y, x] + "\t" + "(z: " + z + " ; y: " + y + " x: " + x + " )" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("================================");
}
Console.WriteLine();
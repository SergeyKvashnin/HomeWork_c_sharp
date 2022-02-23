Console.Clear();
int j = 0;
Console.Write("Введите колличество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] myArray = new int[n]; // 
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент по индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine()); ;
}
Console.WriteLine();
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        j++;
    }
    Console.Write(myArray[i] + " ,");
}
Console.WriteLine();
Console.WriteLine("количество чисел больше нуля: " + j);


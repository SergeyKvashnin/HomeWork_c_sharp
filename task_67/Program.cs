// Задача 67: Показать натуральные числа от N до 1, N задано.
// Пример: N = 5. -> "5, 4, 3, 2, 1"
Console.Clear();
Console.WriteLine("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num1 = 1;

string NumberRec(int num1, int num2)  
{
    if (num1 <= num2) 
        return ($"{num2} {NumberRec( num1, num2 - 1)}");       

    else  return String.Empty;
}
Console.Write(NumberRec(num1, num2));
// / Найти сумму элементов от M до N, N и M заданы

Console.Clear();
Console.WriteLine();

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SUMM(int M, int N)
{
    int summ = M;
    if (M < N)
    {
        summ += SUMM(M + 1, N);
    }
    return summ;
}

int result = SUMM(M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} = {result}");
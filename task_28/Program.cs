// посчитать сумму чисел числа 

// Подсчитайте сумму цифр в числе.
Console.Clear();
Console.WriteLine("введите число: "); 
int numA = int.Parse(Console.ReadLine());
int summ = 0;
while (numA>0)
{
    summ=summ+numA%10;
    numA=numA/10;
}
Console.WriteLine(summ);
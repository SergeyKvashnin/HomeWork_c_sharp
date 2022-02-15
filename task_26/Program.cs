// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("введите число А: ");
int numA = int.Parse(Console.ReadLine());           
Console.WriteLine("введите степень числа: ");
int numB = int.Parse(Console.ReadLine());           

int result = 1;

for (int count = 1; count<=numB; count++) 
{
    result = numA * result;
}
Console.WriteLine(result);   
    

 
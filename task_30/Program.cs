// Показать кубы чисел заканчивающихся на четную цифру 


int [] mass = new int [8];    
for (int i = 0; i < 8; i++)              
{
    mass[i] =  new Random().Next(1, 9);
    Console.Write(" " + mass[i]);
    
}

Console.WriteLine();

for (int i = 0; i < mass.Length; i++)
{
    if(mass[i]%2 == 0)
    {
        Console.Write(Math.Pow(mass[i], 3)  + " ");
    }
}


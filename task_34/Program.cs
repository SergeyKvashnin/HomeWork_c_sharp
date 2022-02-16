// / Написать программу замену элементов массива на противоположные

Console.Clear();
int[] mass = new int[10]; 
 
for (int i = 0; i < mass.Length ; i++) 
{ 
    mass[i] = new Random().Next(0,10); 
    Console.Write(mass[i] + "\t");
    Console.WriteLine(mass[i]*-1  ); 
    
} 
Console.WriteLine();
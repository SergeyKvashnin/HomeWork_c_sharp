//
Console.Clear();
    
Console.WriteLine("Введите координату х1: ");
double x1 = double.Parse(Console.ReadLine());
    //Console.WriteLine(x1);
Console.WriteLine("Введите координату х2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1: "); //3я точка
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z2 = double.Parse(Console.ReadLine());
double i = 2;       // степень

double A = Math.Pow((x2-x1), i);
double B = Math.Pow((y2-y1), i);
double D = Math.Pow((z2-z1), i);

double C = Math.Sqrt(A+B+D);

Console.WriteLine("расстояние между 2х точек: " + C);

   
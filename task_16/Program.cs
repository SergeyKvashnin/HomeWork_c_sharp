// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();

//int N = new Random().Next(1, 7);        Если решать через Рандом, то нужно убирать " " в if и else if
//Console.WriteLine(N);                   Строка для рандома
Console.WriteLine("введите чилсло: от 1 до 7 ");

string N = Console.ReadLine();

Console.WriteLine("День недели: " + N);         //строка для красоты 

if (N == "1")
{
    Console.WriteLine("Понедельник: " + "Рабочий день недели");
}
else if (N == "2")
{
    Console.WriteLine("Вторник: " + "Рабочий день недели");
}
else if (N == "3")
{
    Console.WriteLine("Среда: " + "Рабочий день недели");
}
else if (N == "4")
{
    Console.WriteLine("Четверг: " + "Рабочий день недели");
}
else if (N == "5")
{
    Console.WriteLine("Пятница: " + "Рабочий день недели");
}
else if (N == "6")
{
    Console.WriteLine("Суббота: " + "Выходной день недели");
    
}
else if (N == "7")
{
    Console.WriteLine("Воскресенье: " + "Выходной день недели");
}
else Console.WriteLine("Не верно введен день недели");   //при изспользовании рандома, строка не нужна



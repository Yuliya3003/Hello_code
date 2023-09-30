// Напишите программу, которая на вход принимает координаты двух точек и находит расстояние
// между ними в 2D пространстве 

Console.WriteLine("Введите координату X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
Console.WriteLine(distance);
// Напишите программу, которая на вход принимает координаты 
// (X, Y), а выдает номер плоскости, в которой она находится

Console.WriteLine("Введите число"); 
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число"); 
int Y = Convert.ToInt32(Console.ReadLine());

if ((X > 0) && (Y > 0)) {
    Console.WriteLine("1");
}
else if ((X < 0) && (Y > 0)) {
    Console.WriteLine("2");
}
else if ((X < 0) && (Y < 0)) {
    Console.WriteLine("3");
}
else if ((X >0) && (Y < 0)) {
    Console.WriteLine("4");
} else { 
    Console.WriteLine("Введены некорректные значения X Y");
}

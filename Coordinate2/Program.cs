// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат в этой четверти (х, у)

Console.WriteLine("Введите число от 1 до 4"); 
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1) {
    Console.WriteLine("X>0, Y>0");
} else
if (n == 2) {
    Console.WriteLine("X<0, Y>0");
} else
if (n == 3) {
    Console.WriteLine("X<0, Y<0");
} else
if (n == 4) {
    Console.WriteLine("X>0, Y<0");
}
else {
    Console.WriteLine("Такой четверти нет");
}
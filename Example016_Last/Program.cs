﻿// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает
// последню цифру этого числа
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра равна " + x%10);

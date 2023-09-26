int num1 = new Random().Next(100,1000);
Console.WriteLine(num1);
int num2 = new Random().Next(100,1000);
Console.WriteLine(num2);
if (num1 == num2*num2 || num2 == num1*num1) {
    Console.WriteLine("Yes");
} else {Console.WriteLine("No");}

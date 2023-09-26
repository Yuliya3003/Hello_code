int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num1 = num/100;
int num2 = num%10;
int resault = num1*10 + num2;
Console.WriteLine(resault);

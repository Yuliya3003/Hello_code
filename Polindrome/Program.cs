bool isPolindrome(int x) {
if ((x > 99999) || (x < 10000)) {
    Console.WriteLine("Число не пятизначное");
    return false;
} else {
       int[] ints = new int[5];
       for (int i=0; i < 5; i++) {
             ints[i] = x%10;
             x = x/10;
       }
       if ((ints[0] == ints[4]) && (ints[1] == ints[3])) {
            return true;
       }  else {
        Console.WriteLine("Число не полиндром");
        return false;
}
}
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPolindrome(num));
int number1 = new Random().Next(1,10);
int number2 = new Random().Next(1,10);
int number3 = new Random().Next(1,10);
int number4 = new Random().Next(1,10);
int number5 = new Random().Next(1,10);
int max = number1;
int[] weights = {number1, number2, number3, number4, number5};

for (int i=0; i< weights.Length; i++) {
    Console.Write(weights[i]+ " ");
}
Console.WriteLine();
for (int i=0; i< weights.Length; i++) {
    if (weights[i] > max) {
        max = weights[i];
    }
}
Console.WriteLine(max);

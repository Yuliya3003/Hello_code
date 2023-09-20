int Max(int[] ints) {
    int max = ints[0];
    for (int i=0; i < ints.Length; i++) {
        if (max < ints[i]) {
            max = ints[i];
        }
    }
    return max;
}

int number1 = new Random().Next(1,10);
int number2 = new Random().Next(1,10);
int number3 = new Random().Next(1,10);
int number4 = new Random().Next(1,10);
int number5 = new Random().Next(1,10);
int number6 = new Random().Next(1,10);
int number7 = new Random().Next(1,10);
int number8 = new Random().Next(1,10);
int number9 = new Random().Next(1,10);
int[] weights = {number1, number2, number3, number4, number5, number6, number7, number8, number9};

Console.WriteLine(Max(weights));

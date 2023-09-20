int Max(int[] ints) {
    int max = ints[0];
    for (int i=0; i < ints.Length; i++) {
        if (max < ints[i]) {
            max = ints[i];
        }
    }
    return max;
}

int[] weights = {11, 45, 67, 78, 43, 101};

Console.WriteLine(Max(weights));

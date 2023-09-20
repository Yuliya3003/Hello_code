int? Find(int[] ints, int x) {
   for (int i=0; i < ints.Length; i++) {
    if (ints[i] == x) {
        return i;
    } 
   }
   return null;
}

int[] test = {56, 10, 5, 6, 8, 56};
Console.WriteLine(Find(test, 56));


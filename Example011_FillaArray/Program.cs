void FillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] collection) {
    for (int i=0; i < collection.Length; i++) {
        Console.Write(collection[i] + " ");
    }
}

int? IndexOf(int[] collection, int find) {
    int index = 0;
    while (index < collection.Length) {
        if(collection[index] == find) {

            return index;
        } 
        index++;
    }
return null;
}

int[] Array = new int[10];
FillArray(Array);
PrintArray(Array);
Console.WriteLine("");
Console.WriteLine(IndexOf(Array, 9));

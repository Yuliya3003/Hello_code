double distance(int[] a, int[] b) {
    double distance1 = Math.Sqrt((a[0]-b[0])*(a[0]-b[0])+(a[1]-b[1])*(a[1]-b[1])+(a[2]-b[2])*(a[2]-b[2])); 
return distance1;
}
int[] x = {1, 1, 1};
int[] y = {3, 3, 3};
Console.WriteLine(distance(x,y));

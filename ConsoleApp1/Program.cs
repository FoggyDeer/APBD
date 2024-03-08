// See https://aka.ms/new-console-template for more information

Console.WriteLine(";Hedllo,, World!!");
Console.WriteLine(getAvg(new int[]{1, 2, 3, 4, 5}));
static double getAvg(int[] arr)
{
    int sum = 0;
    foreach (var num in arr)
    {
        sum += num;
    }

    return (double)sum / arr.Length;
}
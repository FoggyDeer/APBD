// See https://aka.ms/new-console-template for more information

Console.WriteLine(";Hedllo,, World!!");
Console.WriteLine(getAvg(new int[]{1, 2, 3, 4, 5}));
Console.WriteLine(GetMax(new int[]{1,2,3,4,5,11,22,55,0}));
static double getAvg(int[] arr)
{
    int sum = 0;
    foreach (var number in arr)
    {
        sum += number;
    }

    return (double)sum / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = 0;
    foreach (var num in arr)
    {
        if (num > max)
            max = num;
    }

    return max;
}
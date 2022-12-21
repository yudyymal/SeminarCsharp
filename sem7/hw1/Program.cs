double[,] arr = new double[3, 4];

for (int m = 0; m < arr.GetLength(0); m++)
{
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        double number = new Random().Next(-10, 11) + new Random().NextDouble();
        arr[m, n] = Math.Round(number, 1);
    }
}

for (int m = 0; m < arr.GetLength(0); m++)
{
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        Console.Write($"{arr[m, n]}  ");
    }
    Console.WriteLine();
}
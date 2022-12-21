int[,] arr =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
double sumInColumn;
double averageInColumn;

Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int n = 0; n < arr.GetLength(1); n++)
{
    sumInColumn = 0;
    averageInColumn = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        sumInColumn = sumInColumn + arr[m, n];
    }
    averageInColumn = sumInColumn / 3;
    Console.Write($"{Math.Round(averageInColumn,1)}  ");
}

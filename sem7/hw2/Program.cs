int[,] arr =
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

System.Console.WriteLine("Введите число, а я скажу индексы в массиве данного числа, если оно там есть");
int number = int.Parse(Console.ReadLine());
bool here = false;

for (int m = 0; m < arr.GetLength(0); m++)
{
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        if (arr[m, n] == number)
        {
            here = true;
            Console.WriteLine($"Индексы числа {number} в массиве: {m}, {n}");
        }
    }
}
if (here == false)
{
    Console.WriteLine($"Числа {number} нет в массиве");
}
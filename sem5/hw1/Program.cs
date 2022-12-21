int[] array = new int[4];
int result = 0;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

int SearchPositiveNumbers(int[] mass)
{
    int count = mass.Length;
    int pos = 0;
    while (pos < count)
    {
        arrayNumber = 
        if (mass[pos] % 2 = 0)
        {
            result++;
        }
        pos++;
    }
    return(result);
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {col[position]}");
        position++;
    }
}

FillArray(array);
PrintArray(array);
SearchPositiveNumbers(array);

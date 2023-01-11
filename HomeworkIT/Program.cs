string[] words = new string[] { "Hello", "2", "World", ":-)" };

// Введение метода для определение длины элемента в массиве

int LengthOfWord(string a)
{
    return a.Length;
}

// Счётчик, вычсчитывающий количество элементов в массиве с длиной меньше или равной 3-ём

int count = 0;
for (int i = 0; i < words.Length; i++)
{
    if (LengthOfWord(words[i]) <= 3)        { count++; }
}

// Создание нового массива для дальнейшего хранения элементов по условию задачи
string[] wordsLessFour = new string[count];

count = 0;
for (int i = 0; i < words.Length; i++)
{
    if (LengthOfWord(words[i]) <= 3)
    {
        wordsLessFour[count] = words[i];
        count++;
    }
}

// Метод вывода массива

void PrintArray(string[] array)
{
    int lengthOfArray = array.Length;
    for (int j = 0; j < lengthOfArray; j++)
    {
        Console.Write($"{array[j]}   ");

    }
}

// Выводим вновь созданный массив, исходя из условий задачи

PrintArray(wordsLessFour);
string[] words = new string[] { "Hello", "2", "World", ":-)" };
// string[] words = new string[] { "1234", "1567", "-2", "computer science" };
// string[] words = new string[] { "Russia", "Denmark", "Kazan"};

int LengthOfWord(string a)
{
    return a.Length;
}

    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (LengthOfWord(words[i]) <= 3)        { count++; }
    }

    System.Console.WriteLine(count);

string[] wordsLessFour = new string[count];

// for (int n = 0; n < words.Length; n++)
// {
//     Console.WriteLine(LengthOfWord(words[n]));
//     Console.WriteLine(words[n]);
// }

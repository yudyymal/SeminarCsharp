string[] words = new string[] { "Hello", "2", "World", ":-)" };

int LengthOfWord (string a)
{
    return a.Length;
}

for (int n = 0; n < words.Length; n++)
{
    Console.WriteLine(LengthOfWord(words[n]));
    Console.WriteLine(words[n]);
}

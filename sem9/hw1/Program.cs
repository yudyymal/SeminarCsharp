Console.WriteLine("Введите значение N. Программа выведет все натуральные числа от N до 1");
int number = int.Parse(Console.ReadLine());

string IntegersFromN(int a, int n)
{
    if (a <= n) return IntegersFromN(a + 1, n) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(IntegersFromN(1,number));
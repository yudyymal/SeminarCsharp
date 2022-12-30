Console.WriteLine("Программа найдёт сумму натуральных элементов в промежутке от M до N");
Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());

int IntegersSum(int a, int b)
{
    if (b == a) return a;
    else return b + IntegersSum(a, b - 1);
}

Console.WriteLine(IntegersSum(m,n));
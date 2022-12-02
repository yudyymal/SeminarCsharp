Console.WriteLine("Введите число 1");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите число 2");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);
Console.WriteLine("Введите число 3");
string с = Console.ReadLine();
int numberС = Convert.ToInt32(с);

int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberС > max)
{
    max = numberС;
}
Console.WriteLine("Наибольшее из данных чисел - число " + max);
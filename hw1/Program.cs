
Console.WriteLine("Введите число 1");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);
Console.WriteLine("Введите число 2");
string b = Console.ReadLine();
int numberB = Convert.ToInt32(b);

int max = numberA;
int min = numberB;

if (max == min)
{
    Console.WriteLine("Данные числа равны");
}
else if (numberB > max)
{
    max = numberB;
    min = numberA;
}
if (max != min)
{
    Console.WriteLine("Наибольшее из данных чисел - число " + max + " Наименьшее - " + min);
}
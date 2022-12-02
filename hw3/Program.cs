Console.WriteLine("Введите число, а я скажу, чётное или нечётное оно");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);

if ((numberA % 2) == 0)
{
    Console.WriteLine("Данное число чётное");
}
else 
{
Console.WriteLine("Данное число нечётное");
}
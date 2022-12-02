Console.WriteLine("Введите число N, а я выдам все чётные от 1 до N");
string a = Console.ReadLine();
int numberA = Convert.ToInt32(a);

for (int i = 1; i <= numberA; i++)
{
    if ((i % 2) == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}

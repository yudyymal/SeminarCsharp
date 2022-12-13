Console.Clear();
Console.WriteLine("Программа возведения числа A в натуральную степень B");
Console.WriteLine("Введите число A"); 
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B"); 
int b = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} равняется {result}");
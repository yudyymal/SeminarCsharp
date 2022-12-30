Console.WriteLine("Программа вычисления функции Аккермана A(m,n)");
Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
Console.WriteLine($"A({m},{n}) = {A(m,n)}");
Console.WriteLine("Введите трёхзначное число");

int num = int.Parse(Console.ReadLine());

if (num > 999 || num < 100)
{
    Console.WriteLine("Число не является трёхзначным или отрицательное");
}
else
{
    Console.WriteLine("Вторая цифра в числе - " + (num.ToString().ToCharArray()[1]));
}
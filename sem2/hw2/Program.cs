Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine());

if (num < -99) // Сделано, чтоб работало с трёхзначными отрицательными
{
    num = num * (-1);
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра в числе - " + (num.ToString().ToCharArray()[2]));
}
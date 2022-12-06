Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");

int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7) // Если вдруг ввели значение вне пределов (1;7)
{
    Console.WriteLine("Попробуйте ещё раз"); 
}
else if (num ==6 || num == 7)
{
    Console.WriteLine(num + "-ой день в неделе является выходным");
}
else
{
    Console.WriteLine(num + "-й день в неделе является рабочим");
}
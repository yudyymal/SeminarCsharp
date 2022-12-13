Console.Clear();
Console.WriteLine("Введите число, а я выдам сумму цифр в данном числе");
string str = Console.ReadLine();
int sum = 0;

for (int i = 0; i < str.Length; i++)
{
    int number = int.Parse(str[i].ToString());
    sum += number;
}

Console.WriteLine($"Сумма цифр в данном числе равняется: {sum}");
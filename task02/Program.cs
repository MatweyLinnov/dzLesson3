
int result,num;

System.Console.Write("Введити любое число : ");
num = int.Parse(System.Console.ReadLine());
result = 0;
while (num != 0)
{
    result += num % 10;
    num /= 10;
}

Console.WriteLine($"Сумма цифр в числе = {result}");



int numA, numB;

System.Console.Write("Число А:");
numA = int.Parse(System.Console.ReadLine());
System.Console.Write("Число B:");
numB = int.Parse(System.Console.ReadLine());
double result = 0;
for (int i = 0; i <= numB; i++)
{
    result = Math.Pow(numA, numB);
}
System.Console.WriteLine($"число {numA} в степени числа {numB} ровняется {result}");


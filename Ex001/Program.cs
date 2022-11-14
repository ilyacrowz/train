Console.WriteLine("Введите перво число a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 >= max)
{
    max = num2;
}
Console.WriteLine($"a = {num1} b = {num2} -> max = {max}");
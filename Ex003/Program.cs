Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1%2 == 0)
{
    Console.WriteLine($"{num1} - четное число");
}
else
{
   Console.WriteLine($"{num1} - нечетное число");
}
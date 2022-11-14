Console.WriteLine("Введите перво число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= num1)
    {
        if (count%2 ==0)
        {
           Console.Write($" {count} "); 
        }
    count++;
    }

Console.WriteLine("Введите первое число");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int two = Convert.ToInt32(Console.ReadLine());
if (one == two)
    {
        Console.WriteLine("оба числа одинаковы");
    }
else if (one > two)
    {
        Console.WriteLine("Первое число больше");
    }
else if (one < two)
    {
        Console.WriteLine("Второе число больше");
    }
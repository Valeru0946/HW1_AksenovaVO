// Задача 4
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите третье число");
int d = Convert.ToInt32(Console.ReadLine ());
if (a < b)
{
    if (d > b)
    {
        Console.WriteLine("Третье число максимальное");
    }
}
if (a > b)
{
    if (a > d)
    {
        Console.WriteLine("Первое число максимальное");
    }
}
if (b > a)
{
     if (b > d)
    {
        Console.WriteLine("Второе число максимальное");
    }
}
if (a ==b)
{
     if (b == d)
    {
        Console.WriteLine("Числа равны");
    }
}


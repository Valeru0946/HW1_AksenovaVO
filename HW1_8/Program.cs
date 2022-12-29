// Задача 8
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (true)
{
    if (i % 2 == 0)
    {
        Console.WriteLine (i + " ");   
    }
    if (i >= N)
    {
        break;
    }
    i++;
}
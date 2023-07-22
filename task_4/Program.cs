Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int num = 1;
while (num <= a)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");

    }
    num++;
}


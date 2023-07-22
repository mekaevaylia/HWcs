Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b > a) {
   max = b;
};
if(c > max) {
    max = c;
};
Console.WriteLine($"Maксимальное - {max}");

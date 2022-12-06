Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
n = n/10;
n = n%10;

Console.WriteLine($"{n}");
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if ((n > 0) & (n < 6)) {
    Console.WriteLine("нет");
} else if ((n > 5) & (n < 8)) {
    Console.WriteLine("да");
} else {Console.WriteLine("Неверные данные");}
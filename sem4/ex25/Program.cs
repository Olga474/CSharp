Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a;
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < b; i++) {
    a = a1*a;
}

Console.WriteLine($"{a1}^{b}={a}");
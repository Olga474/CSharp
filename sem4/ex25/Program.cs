int deg(int a, int b) {
int a1 = a;
for (int i = 1; i < b; i++) {
    a = a1*a;
}
return a;
}

Console.Write($"Ведите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ведите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{deg(k, n)}");
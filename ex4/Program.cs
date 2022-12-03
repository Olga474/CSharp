Console.Write("Введите число a:");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c:");
int c = int.Parse(Console.ReadLine()!);

if ((a>=b)&(a>=c)) {
    Console.WriteLine($"max = {a}");
} 
else if ((b>=a)&(b>=c)) {
    Console.WriteLine($"max = {b}");
} 
else {
    Console.WriteLine($"max = {c}");
}

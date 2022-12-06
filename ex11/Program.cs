Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n<100) {
    Console.WriteLine("Третьей цифры нет");
} else {
    string s = n.ToString();
    
    Console.WriteLine($"{s[2]}");
}
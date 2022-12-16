int sum_numb(int a) {

int sum = 0;
do {
    sum = sum + a%10;
    a = a/10;
} while (a != 0);

return sum;
}

Console.Write($"Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{sum_numb(n)}");
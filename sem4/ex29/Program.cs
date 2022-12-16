void mass () {
    int[] numbers = new int[8];
    for (int i =0; i < 8; i++) {
        Console.WriteLine($"Ведите элемент массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        numbers[i] = n;
    }
    Console.Write("[");
    for (int i = 0; i < 7; i++)
        {
    Console.Write($"{numbers[i]}, ");
        }
    Console.Write($"{numbers[7]}");
    Console.Write("]");
}

mass();
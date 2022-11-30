// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Ackermann(m, n));

int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Ошибка, введите положительные числа!");
        return 0;
    }
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(n, m);
}

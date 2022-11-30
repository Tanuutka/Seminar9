//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (m > n)
{
    int sumOfNatural = SumOfNaturalNumbers(m, n);
    Console.WriteLine(sumOfNatural);
}
else
{
    int buffer = m;
    m = n;
    n = buffer;
    int sumOfNatural = SumOfNaturalNumbers(m, n);
    Console.WriteLine(sumOfNatural);
}

int SumOfNaturalNumbers(int number1, int number2, int sum = 0)
{
    if (number1 <= number2)
    {
        return sum + number1;
    }
    else
    {
        sum = sum + number1;
        number1--;
        return SumOfNaturalNumbers(number1, number2, sum);
    }
}
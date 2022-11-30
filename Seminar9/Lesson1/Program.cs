// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int[] arrayN = ListOfNaturalNumbers(n);
PrintArray(arrayN);

int[] ListOfNaturalNumbers(int number)
{
    int[] naturalArray = new int[number];
    for (int i = 0; i < naturalArray.Length; i++)
    {
        if (number != 0)
        {
            naturalArray[i] = number;
            number--;
            ListOfNaturalNumbers(number);
        }
    }
    return naturalArray;
}

void PrintArray(int[] arr)
{
    Console.Write(String.Join(", ", arr));
}
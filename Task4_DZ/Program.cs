// Задание из лекции на самостоятельное решение. Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать массив, состоящий из цифр этой строки.

// Функция - формирование строки только из цифр
using System.Net.NetworkInformation;

string GetDigitsString(string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if (char.IsDigit(e))
        {
            digits += e;
        }
    }
    return digits;
}

// Функция - определяем количество цифр в числе
int GetCountDigitOfNumber(long n)
{
    int countDigit = 0;
    while (n > 0)
    {
        n /= 10;
        countDigit++;
    }
    return countDigit;
}

// Функция - Создание массива из числа
long[] CreateArrayOfNumber(long n)
{
    long countDigit = GetCountDigitOfNumber(n);
    long[] array = new long[countDigit];
    for (long i = countDigit - 1; i >= 0; i--)
    {
        array[i] = n % 10;
        n /= 10;
    }
    return array;
}

// Ввод данных
Console.Clear();
Console.Write("Напечатайте строку: ");
string stringDigits = Console.ReadLine()!;

string result = GetDigitsString(stringDigits);
Console.WriteLine($"Строка из цифр (без символов): {result}");

long number = long.Parse(result);
int countDigit = GetCountDigitOfNumber(number);
Console.WriteLine($"Количество цифр в строке: {countDigit}");

long[] arr = CreateArrayOfNumber(number);
Console.WriteLine($"Массив из цифр числа: [{string.Join(", ", arr)}]");
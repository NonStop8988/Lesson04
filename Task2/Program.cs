// Задача №2. Назовём число «интересным» если его сумма цифр чётная. Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные» элементы массива.

// Функция - создание двумерного целочисленного массива
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

// Функция - подсчет суммы цифр числа
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

// Функция - Проверка элемента на интересность (четность)
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

// Функция - вывод двумерного массива на экран
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"Строка {i} - "); // Название каждой строки
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(); // Переход на новую строку
    }
}

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}
// Задача №2. Назовём число «интересным» если его сумма цифр чётная. Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные» элементы массива.

// Функция - создание двумерного целочисленного массива
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    // Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 1000);
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

// Функция - Проверка элемента на "интересность" (четность)
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    return sumOfDigits % 2 == 0;
    // if (sumOfDigits % 2 == 0)
    // {
    //     return true;
    // }
    // return false;
}

// Функция - вывод двумерного массива на экран
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"Строка {i} - "); // Название каждой строки
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); // Вывод элементов строки массива
        }
        Console.WriteLine(); // Переход на новую строку
    }
}

// Функция - Вывод "интересных" элементов массива или их отсутствие
void ShowInterestingElements(int[,] matrix)
{
    Console.Write("'Интересные' элементы массива: ");
    int count = 0;
    foreach (int e in matrix)
    {
        if (IsInteresting(e) == true)
        {
            Console.Write(e + " ");
            count++;
        }
    }
    
    if (count == 0)
    {
        Console.Write("отсутствуют");
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
ShowInterestingElements(matrix);
// Задача №1. Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел. Вывести его элементы на экран

// int[,] matrix = new int[3, 5];

// // Создаем массив, проходимся по каждой строке двумерного массива
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// // Выводим массив на экран
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // Переход на новую строку
// }

// Функция - создание двумерного целочисленного массива
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
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

// Вводим переменные
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
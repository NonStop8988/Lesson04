// Задача №3. Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать новую строку, состоящую из букв исходной строки.

// Функция - считывание символов со строки
string GetLettersFromString(string s)
{
    string leters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            leters += e;
        }
    }
    if (leters == "")
    {
        Console.WriteLine("В заданной строке английские буквы отсутствуют");
    }
    return leters;
}

Console.Clear();
Console.WriteLine("Напечатайте строку");
string str = Console.ReadLine()!;
string result = GetLettersFromString(str);
Console.WriteLine(result);

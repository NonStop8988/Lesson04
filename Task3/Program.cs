// Задача №3. Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromString(string s)
{
    string leters = "";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            leters += e;
        }
    }
    return leters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);

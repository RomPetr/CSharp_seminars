/* Задача 1 
//Задайте массив символов (тип char[]).
//Создайте строку из символов этого массива
//Пример:
// [a, b, c, d, e] => "abcde"

string GetStringFromCharArray (char[] array)
{
    string result = string.Empty; //""
    foreach (char symbol in array)
    // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
    {
        result = result + symbol;
    }
    return result;
}

char[] chars =  {'1', 'd', '!', '2', 'f'};
Console.WriteLine($"Массив: [{string.Join(";", chars)}]");
string res = GetStringFromCharArray(chars);
Console.WriteLine(res);
*/
//---------------------------------------------------------------
/* Задача 2 
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Пример:
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
        //chars[0] = str[0], chars[0]=h
        //chars[1] = str[1], chars[1]=i
    }
    return chars;
}

string str = "Hello world";
Console.WriteLine($"Строчка исходная: {str}");
char[] chars = ConvertStringToCharArray(str);
Console.WriteLine($"Массив: [ {String.Join(";", chars)} ]");
*/
/* Задача 3 
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount (string str)
{
    // str = "hello", 'h' - 1 символ, char
    string vovels = "aoueyi"; // Гласные буквы в англ. алфавите
    int vovelsCount = 0; // Количество гласных 
    foreach (char symbol in str) // Получает каждый символ введенной строчки
    {
        // 'a' == a, o, u, e, y, i
        foreach (char vovel in vovels) // Получаем гласные
        {
            if (symbol == vovel) // Нашли гласную букву
            {
                vovelsCount++; // vovelsCount = vovelsCount + 1
                break; // Если нашли гласную, переходим к след.букве
            }
        }
    }
    return vovelsCount;
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower(); // нижний регистр, "HI" -> "hi"
// ToUpper() - верхний ("hi" => "HI")
Console.WriteLine($"В строчке: {inputString} в нижн. регистре : {GetVovelsCount(inputString)} гласных");
*/
//---------------------------------------------------------------
/*Домашняя работа */
// Задача 1
//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

string GetStringFromCharMatrix(char[,] matrix)
{
    string result = string.Empty; //""
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result = result + matrix[i, j];
        }
    }
    return result;
}

void PrintCharMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

char[,] ch_matrix = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
Console.WriteLine("Исходный массив символов:");
PrintCharMatrix (ch_matrix);
string res = GetStringFromCharMatrix(ch_matrix);
Console.WriteLine ("Получившаяся строка:");
Console.WriteLine(res);

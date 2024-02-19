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
/* Задача 2 */
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

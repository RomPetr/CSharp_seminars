/* Задача 1 */
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
Console.WriteLine();
string res = GetStringFromCharArray(chars);
Console.WriteLine(res);
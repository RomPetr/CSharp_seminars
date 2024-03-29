﻿//Создание двумерного массива
/*Random rnd = new Random();
int[,] matrix = new int[7, 8];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = rnd.Next(1, 10);
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/
//---------------------------------------------------------------
/* Задача 1: 
//Создание и вывод на экран двумерного массива через функции 

int[,] CreateMatrix (int rowCount, int columsCount)
{
    Random rnd = new Random();
    int[,] matrix = new int[columsCount, rowCount];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1, 10);
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] array = CreateMatrix (4,5);
ShowMatrix (array);
*/
//---------------------------------------------------------------
/* Задача 2:
//Создать двумерный массив, состоящий из целых чисел.
//Вывести на экран "интересные" элементы массива.
//Назовем число интересным, если сумма его цифр четная

int[,] CreateMatrix (int rowCount, int columsCount)
{
    Random rnd = new Random();
    int[,] matrix = new int[columsCount, rowCount];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(1, 1000);
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] array = CreateMatrix (4,5);
ShowMatrix (array);
Console.WriteLine ();

foreach (int e in array)
{
    if (IsInteresting (e)) Console.WriteLine (e);
}

bool IsInteresting (int value)
{
    int sumOfDigits = GetSumOfDigits (value);
    if (sumOfDigits % 2 == 0) return true;
    return false;
}

int GetSumOfDigits (int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}
*/

/* Задача 3: 
//Ввести строку состоящию из букв и цифр и оставить только буквы

string GetOfLettersFromString (string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter (e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine ();
string result = GetOfLettersFromString (str);
Console.WriteLine (result);
*/
//---------------------------------------------------------------
/* Задача 4:*/
//Считать с консоли строку, состоящую из цифр и латинских букв.
//Сформировать массив, состоящий из цифр этой строки.
//Пример: abc123def06g => [1, 2, 3, 0, 6]

 int GetOfNumbersFromString (string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if (char.IsAsciiDigit (e) == true)
        {
            digits += e;
        }
    }
    int number = Convert.ToInt32 (digits);
    return number;
}

int CalculateMatrixSize (int n)
{
    int number = n;
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

void CreateDigitMatrix (int[] arr, int res_num)
{
    int stepen = arr.Length - 1;
    int number = (int) Math.Pow (10, stepen);
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (res_num / number);
        res_num = res_num - (arr[i] * number);
    
        number /= 10;
    }
    Console.Write($"[ {string.Join(";", arr)} ]");
}

Console.WriteLine ("Please, enter the string of letters and numbers:");
string str = Console.ReadLine ();
int result_number = GetOfNumbersFromString (str);
//Console.WriteLine (result_number);
int N = CalculateMatrixSize (result_number);
//Console.WriteLine (N);
int[] arr = new int[N];

CreateDigitMatrix (arr, result_number);
Console.WriteLine ();

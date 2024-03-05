/* Задача 1 
//Написать рекурсивную функцию вычисления факториала числа N

int FactRecurs(int n)
{
    if (n == 1 || n == 0)
        return 1;
    return n * FactRecurs(n - 1);
}

Console.Write ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write ("\nФакториал данного числа равен: ");
Console.WriteLine (FactRecurs(N));
*/
//---------------------------------------------------------------
/* Задача 2 
// Напишите программу, которая будет принимать 
// на вход число и  возвращать сумму его цифр.
// Пример
// 123 => 6 (1+2+3 = 6)
// 63 => 9
int SumOfDigits (int number)
{
    // Базовый случай
    if (number == 0) return 0; // 3 + 6 + 0 = 9
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
}
Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write ("Сумма цифр этого числа равна: ");
Console.WriteLine (SumOfDigits(number));
*/
//---------------------------------------------------------------
/* Задача 3 
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5
// start=1, end=N
void ShowNumbers(int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers (start+1, end);
}
ShowNumbers(1, 5); // start = 1, end = 5
*/
//---------------------------------------------------------------
/*Домашняя работа
// Задача 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNumbers(int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers (start+1, end);
}

Console.Write ("Введите начальное значение: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите конечное значение: ");
int end = Convert.ToInt32(Console.ReadLine());
ShowNumbers(start, end);
Console.WriteLine();
*/
//---------------------------------------------------------------
// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkkermansFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AkkermansFunction(n - 1, 1);
    }
    else
    {
        return AkkermansFunction(n - 1, AkkermansFunction(n, m - 1));
    }
}

Console.Write ("Введите начальное значение функции Аккермана: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите конечное значение функции Аккермана: ");
int end = Convert.ToInt32(Console.ReadLine());
int AkkermanResult = AkkermansFunction(start, end);
Console.WriteLine(AkkermanResult);

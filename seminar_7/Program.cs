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
/* Задача 2 */
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
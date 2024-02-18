/* Рекурсия */
/* Задача 1 */
// Найти факториал числа N

// int FactRecurs(int n)
// {
//     if (n == 1 || n == 0)
//         return 1;
//     return n * Fact(n - 1);
// }

// int N = 10;
// Console.WriteLine(FactRecurs(N));
//................................
//Решение через цикл for
int FactСycle(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
int N = 10;
Console.WriteLine(FactСycle(N));

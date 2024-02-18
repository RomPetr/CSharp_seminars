/* Рекурсия */
/* Задача 1 */
// Найти факториал числа N

int Fact(int n)
{
    if (n == 1 || n == 0)
        return 1;
    return n * Fact(n - 1);
}

int N = 5;
Console.WriteLine(Fact(N));

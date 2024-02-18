/* Рекурсия */
/* Задача 1 
// Найти факториал числа N

// int FactRecurs(int n)
// {
//     if (n == 1 || n == 0)
//         return 1;
//     return n * FactRecurs(n - 1);
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
*/
//---------------------------------------------------------------
/* Домашнее задание */
//Добавить в код отладочный вывод, который позволит
//увидеть "раскручивание" рекурсии, то есть
//процесс возвратов к местам рекурсивного вызова функции
//Пример:
//Возврат: n=2; fact=1
//Возврат: n=3; fact=2
//Возврат: n=4; fact=6
//Возврат: n=5; fact=24

int count = 0;

int FactRecurs(int n)
{
    count++;
    if (n == 1 || n == 0)
    {
        //Console.WriteLine($"Stop reqursion: n={n}");
        return 1;
    }
    //Console.WriteLine(n);

    return n * FactRecurs(n-1);

}

Console.Write("Введите число для вычисления его факториала: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат:");
Console.WriteLine(FactRecurs(N));
Console.WriteLine("Отладка:");
int num = count;
for (int i = 1; i <= num; i++)
{
    Console.WriteLine ($"Возврат: n = {i}; fact = {FactRecurs(i)}");
}
//Console.WriteLine(count);


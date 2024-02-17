/* Задача 1 
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
    {
        // j, m, k
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}

void SquareElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            if (i % 2 == 0 && j % 2 == 0) // номер стр И номер стл - четными
            {
                matr[i, j] *= matr[i, j];// matr[i, j] = matr[i, j] * matr[i, j];
            } // a = a * 5; a *= 5
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
PrintMatrix(matrix);
Console.WriteLine("Результат:");
SquareElements(matrix); // Изменяем матрицу 
PrintMatrix(matrix);
*/
//---------------------------------------------------------------
/* Задача 2 */
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.


int[,] CreateMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns]; // [стр, столбцы]
    Random rnd = new Random();
    for (int i = 0; i < rows; i++) // rows = matr.GetLength(0)
    {
        // j, m, k
        for (int j = 0; j < columns; j++) // columns = matr.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // [0,100], (0, 101)
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
        } // Закончили обход 0 строки, идем в 1
        Console.WriteLine(); // Перенос на новую строчку
    }
}

int GetMainDiagonalSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            if (i == j)
            {
                sum += matr[i, j];// sum = sum + matr[i, j];
            }
        }
    }
    return sum;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols); // Матрица rows на cols
PrintMatrix(matrix);
Console.WriteLine($"Результат: {GetMainDiagonalSum(matrix)}");
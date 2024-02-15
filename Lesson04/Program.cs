//Создание двумерного массива
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
/* Создание и вывод на экран двумерного массива через функции */

int[,] createMatrix (int rowCount, int columsCount)
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

void showMatrix(int[,] matrix)
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

int[,] array = createMatrix (4,5);
showMatrix (array);

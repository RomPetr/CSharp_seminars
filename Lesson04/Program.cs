//Создание двумерного массива
Random rnd = new Random();
int[,] matrix = new int [7,8];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[i,j] = rnd.Next(1, 10);
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    Console.Write ($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
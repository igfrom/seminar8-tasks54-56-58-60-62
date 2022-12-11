// // Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

int[,] CreateArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(m, n);
PrintArray(matrix);
Console.WriteLine();
int[,] matrix2 = CreateArray(m, n);
PrintArray(matrix2);
int[,] matrix3 = CreateArray(matrix.GetLength(0), matrix2.GetLength(1));
if (matrix.GetLength(0) != matrix2.GetLength(1)) 
{
    Console.WriteLine("Количество строк первой матрицы должно быть равно количеству столбцов второй матрицы, попробуй ещё раз");
}
else

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i,j]=0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix3[i,j] += matrix[i,k]*matrix2[k,j];
            }
            
        }
    }
Console.WriteLine();
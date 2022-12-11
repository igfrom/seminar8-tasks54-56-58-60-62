// // Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

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

Console.WriteLine("Для создания прямоугольного двумерного массива, число строк и число столбцов не должно равняться! (m =! n), иначе это будет квадрат");
Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(m, n);
PrintArray(matrix);


int sum = 0;
int minRowSum = int.MaxValue;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix[i,j];
        if (rowSum < minRowSum)
        
            minRowSum = rowSum;
            sum = i;
        
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
                 for(int j = 0;j<matrix.GetLength(1);j++)
                 {
                      Console.Write(matrix[sum, j]+" ");
                 }

// Задача 60: Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите число строк m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число матриц p : ");
int p = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3D = new int[m, n, p];
newArray(matrix3D);
PrintNumber(matrix3D);

void newArray(int[,,] matrix3D)
{
  int[] matrix = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    matrix[i] = new Random().Next(0, 100);
    number = matrix[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (matrix[i] == matrix[j])
        {
          matrix[i] = new Random().Next(0, 100);
          j = 0;
          number = matrix[i];
        }
          number = matrix[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < matrix3D.GetLength(0); m++)
  {
    for (int n = 0; n < matrix3D.GetLength(1); n++)
    {
      for (int p = 0; p < matrix3D.GetLength(2); p++)
      {
        matrix3D[m, n, p] = matrix[count];
        count++;
      }
    }
  }
}
void PrintNumber(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }

}
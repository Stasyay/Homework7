// Транспонирование - 2
// Задана целочисленная квадратная матрица размером N x N. Требуется транспонировать ее относительно побочной диагонали.
// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N – количество строк и столбцов матрицы.
// В каждой из последующих N строк записаны N целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине. 

// 5
// 3 4 9 6 2      0 8 7 1 2  
// 8 2 0 5 1      7 3 8 5 6 
// 4 7 4 8 7      3 3 4 0 9
// 7 1 3 3 8      6 1 7 2 4  
// 5 6 3 7 0      5 7 4 8 3


void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Transposition(int[,] matrix)
{
    int[,] matrixResult = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix[matrix.GetLength(1) - j - 1, matrix.GetLength(0) - 1 - i];
            Console.Write($"{matrixResult[i, j]} ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[n,n];
PrintArray(matrix);
Console.WriteLine();
Transposition(matrix);

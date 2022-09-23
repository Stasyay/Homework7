// Симпатичный узор
// На днях Иван у себя в прихожей выложил кафель, состоящий из квадратных черных и белых плиток. 
// Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток. 
// Теперь Иван переживает, что узор из плиток, который у него получился, может быть не симпатичным. С точки зрения дизайна симпатичным узором считается тот, который не содержит в себе квадрата 2х2, состоящего из плиток одного цвета.

// По заданному расположению плиток в прихожей Ивана требуется определить: является ли выполненный узор симпатичным.
// Входные данные
// содержит 4 строки по 4 символа «1» или «0» в каждой, описывающие узор из плиток. Символ «1» обозначает плитку белого цвета, а «0» - черного.
// Выходные данные
// выведите «Yes», если узор является симпатичным и «No» в противном случае. 

//Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 2);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

void RealeseMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i + 1, j] == matrix[i + 1, j + 1])
            {
                Console.WriteLine("no");
                break;
            }
        }
    }
    Console.WriteLine("yes");
}

int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
RealeseMatrix(matrix);

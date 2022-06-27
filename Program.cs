//branch 1: Task41
//branch 2: Task43

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)*/


double[,] matrix = new double[2, 2];
matrix = FillAnyMatrix(matrix);

double x = (matrix[1, 0] - matrix[0, 0]) / (matrix[0, 1] - matrix[1, 1]);
double y = (matrix[1, 1] * x) + matrix[1, 0];

Console.WriteLine($"Coordinates of the intersection point: ({x}, {y})");


double[,] FillAnyMatrix(double[,] matrix)
{
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
     'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"Input {alphabet[i]}{j + 1} = ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return matrix;
}




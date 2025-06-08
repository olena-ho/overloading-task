using System.Numerics;
using MatrixTask;

var matrix1 = new Matrix("Matrix 5x5", 5,5);

Console.WriteLine(matrix1);

int[,] data2 = { { 1, 2, 3 }, { 4, 5, 6} };
var matrix2 = new Matrix("Matrix 2x3", data2);
Console.WriteLine(matrix2);

Console.WriteLine($"Are { matrix1.Name} and {matrix2.Name} the same? {matrix1 == matrix2}");

int[,] data3 = { { 7, 3, 1 }, { 5, 2, 6} };
var matrix3 = new Matrix("Matrix 2x3", data3);

var matrix4 = matrix2 * matrix3;

Console.WriteLine(matrix4);

var matrix5 = matrix3 - matrix4;
Console.WriteLine(matrix5);
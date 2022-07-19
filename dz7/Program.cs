// // Задача 41
// Console.Write("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
//  Console.WriteLine($"Количество положительных чисел: {count}"); 

// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
 
// var x = (b2 - b1) / (k1 - k2);
// var y = k1 * x + b1;

// if ( k1 == k2) Console.WriteLine( "Прямые параллельны");
// x = Math.Round(x);
// y = Math.Round(y);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");


Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().NextDouble()* 100;
        Console.Write(matrix[i,j] + "\t"); // Литералы
}
Console.WriteLine();
}


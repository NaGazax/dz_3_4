// // Задача 47
// Console.WriteLine("Введиите кол-во строк :");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Введиите кол-во строк :");
// int columns = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().NextDouble() * 100;
//         Console.Write(matrix[i,j] + "\t");
//      }
//     Console.WriteLine();
    
// }

//Задача 50

// int[,] array = {{ 1, 2, 3, 4 }, { 5, 6, 7, 8}};
// Console.Write("Введите искомое число :");
// int find = Convert.ToInt32(Console.ReadLine());
// int m=0, n=0;
// bool f = false;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (find == array[i, j]) { m = i;n = j;f = true; };
//             Console.Write(array[i, j] +"\t");
//         }
//         Console.WriteLine();
// }
// Console.WriteLine();
// if (f)
// Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
// else
// Console.WriteLine("Число не найдено");
 
// Console.ReadKey();
        

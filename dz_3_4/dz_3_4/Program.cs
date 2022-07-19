// Задание 47
Console.WriteLine("Введиите кол-во строк :");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введиите кол-во строк :");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().NextDouble() * 100;
        Console.Write(matrix[i,j] + "\t");
     }
    Console.WriteLine();
    
}

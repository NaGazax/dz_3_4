Console.Write("Введите  число:");
int N = Convert.ToInt32(Console.ReadLine());
for ( int i = 1; i<=N;)
{
    Console.WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
}
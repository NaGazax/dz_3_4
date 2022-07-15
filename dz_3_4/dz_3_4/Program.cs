
int[] array = new int[6];
int max = 0;
int min = 0;
for (int i = 0; i < array.Length; i++)  
{ 
array[i] = new Random().Next(100, 999);
max = array.Max();
min = array.Min();
}
Console.WriteLine($"({String.Join(";",array)})");
Console.WriteLine($"Максимальное число :  {max} ");
Console.WriteLine($"Минимальное число :  {min} ");
Console.WriteLine($"Разница двух чисел :  {max - min} ");
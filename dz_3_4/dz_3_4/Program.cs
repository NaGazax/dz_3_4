
int[] array = new int[6];
int around = 0;
int sum = 0;
Console.WriteLine("Случайный массив");
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 999);
  Console.WriteLine($"[{String.Join(";",array)}]");
}

foreach(int element in array)
{
     if (element % 2 != 0)
      {
        around++;
        sum += element;
     }
  }
Console.WriteLine();
Console.WriteLine("Количество  нечетных элементов: {0}" , around);
Console.WriteLine();
Console.WriteLine("Сумма  нечетных элементов: {0}" , sum);
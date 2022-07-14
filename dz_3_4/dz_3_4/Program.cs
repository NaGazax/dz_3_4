
int[] array = new int[6];
int around = 0;
Console.WriteLine("Случайный массив");
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 999);
   Console.WriteLine($"[{String.Join(";",array)}]");
}
foreach(int element in array)
{
   Console.Write("{0} ", element);
     if (element % 2 == 0)
      {
        around++;
        
     }
  }
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}" , around);
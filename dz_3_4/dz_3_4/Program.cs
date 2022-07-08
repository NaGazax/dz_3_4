Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum(int number)
{
    int count = Convert.ToString(number).Length;
    int progress = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
      progress = number - number % 10;
      result = result + (number - progress);
      number = number / 10;
    }
   return result;
  }
int sumNumber = sum(number);
Console.WriteLine("Сумма цифр: " + sumNumber);

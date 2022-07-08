Console.Write("Введите пятизначное число:");
string firstNumber = Console.ReadLine();  
int secondNumber = Convert.ToInt32(firstNumber);
if (secondNumber < 10000 | secondNumber >100000) 
{
    Console.WriteLine("Неверное число");
} 
else
{
    if (firstNumber[0] == firstNumber[4] && firstNumber[1] == firstNumber[3])
    {
        Console.WriteLine("Полиндром");
    }
    
    else
    {
         Console.WriteLine("Не полиндром");
    }
}  
    
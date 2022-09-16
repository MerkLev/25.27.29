Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

  int Sum(int number)
  {
    
    int Counter = Convert.ToString(number).Length;
    int LastNum = 0;
    int result = 0;

    for (int i = 0; i < Counter; i++)
    {
      LastNum = number - number % 10;
      result = result + (number - LastNum);
      number = number / 10;
    }
   return result;
  }

int sum = Sum(number);
Console.WriteLine($"Сумма цифр в числе:  {Sum(number)}");
Console.Write("введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow (int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}

Console.WriteLine($"Степень {B} числа {A} = {Pow (A,B)}");
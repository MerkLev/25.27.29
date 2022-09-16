Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Size = Convert.ToString(Number).Length;
int [] GetArray (int Number)
{
    int [] array= new int [Size];
    int [] Waxal= new int [Size];
    for (int i = 0; i < (array.Length); i++)
    {
        int Wax=Number%10;
        Number=Number/10;
        Waxal [i] = Wax;
    }
    for (int i = 0; i < (array.Length); i++)
    {
        array[i] = Waxal[((array.Length-1)-i)];
    }
    return array;
}
int [] resultArray = GetArray(Number);
Console.WriteLine($" Result array: [ {String.Join(", ",resultArray)} ]");
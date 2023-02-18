Console.Clear();

Console.Write("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if( num < 100 || num > 999)
{
    Console.WriteLine("Это не трёхзначное число, попробуйте ещё раз");
}
else
{
    int secondValue = (num % 100) / 10;
    Console.WriteLine($"Среднее число: {secondValue}");
}


Console.Clear();

Console.Write("Введите день недели цифрой ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 8 && num > 0)
{
    if(num > 0 && num < 6)
    Console.WriteLine("Это будний день");
    else
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Перебор, нужно число от 1 до 7");
}
Console.Clear();

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int des = 10; 
if( num / 100 == 0)
    Console.WriteLine("Третьей цифры нет");
else{
while(num / des != 0)
{
    des = des * 10;
}
int result = (num % (des / 100)) / (des / 1000);
Console.WriteLine($"Третья цифра {result}");
}

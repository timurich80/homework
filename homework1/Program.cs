Console.WriteLine("Введите ваше первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{ 
    Console.Write("max -> ");
    Console.WriteLine(a);
}
 
else 
{
    Console.Write("max -> ");
    Console.WriteLine(b);
}
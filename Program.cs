Console.WriteLine("Введите ваше первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
 
if(a > b)
{ 
    max = a;
    if(a > c)
    {
        max = a;
        Console.Write("max -> ");
        Console.WriteLine(a);
    }
    else
    { 
        max = c;
        Console.Write("max -> ");
        Console.WriteLine(c);
    }
}
 
else 
{
    max = b;
    if(b > c)
    {
        max = b;
        Console.Write("max -> ");
        Console.WriteLine(b);
    }
 
    else
    { 
        max = c;
        Console.Write("max -> ");
        Console.WriteLine(c);
    }
 
}
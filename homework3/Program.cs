Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
 
if(a > 0)
{
    a = a % a;
    if(a == 0)
    {
        Console.Write("ДА");
    }
}
else 
{
    Console.Write("НЕТ");
}
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
 
n = n % 10;
Console.Write("последняя цифра введенного числа:  ");
Console.WriteLine(n);
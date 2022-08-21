Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = -n;
int count = 0;
 
while (m <= n)
    {
    Console.Write(m);
    Console.Write(", ");
    m ++;
    }
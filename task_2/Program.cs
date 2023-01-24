System.Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
Console.WriteLine("Третьей цифры нет ");

else
{while (n > 999)
{
    n = n/10;
}
Console.WriteLine("{0} Третья цифра числа ", n % 10);
}

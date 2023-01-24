System.Console.WriteLine("Является ли этот день выходным? Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
case 1:
System.Console.WriteLine("нет");
break;

case 2:
System.Console.WriteLine("нет");
break;

case 3:
System.Console.WriteLine("нет");
break;

case 4:
System.Console.WriteLine("нет");
break;

case 5:
System.Console.WriteLine("нет");
break;

case 6:
System.Console.WriteLine("да");
break;

case 7:
System.Console.WriteLine("да");
break;

default:
System.Console.WriteLine("Введите число от 1 до 7");
break;
}

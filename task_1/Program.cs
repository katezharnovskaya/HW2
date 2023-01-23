System.Console.WriteLine("Введите трехзгначное число: ");

int a = Convert.ToInt32(Console.ReadLine());
int secondnumber = ((a/10 ) % 10 );

Console.WriteLine ( "{0} Вторая цифра трехзначного чмсла ", secondnumber);

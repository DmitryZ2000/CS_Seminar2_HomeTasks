Console.Write("Введите любое трехзначное целое чиисло: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = (number / 10) % 10;
Console.WriteLine($"Вторая цифра введенного числа равна: {digit}");
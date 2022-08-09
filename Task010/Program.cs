Console.Write("Введите любое трехзначное целое чиисло: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = (number / 10) % 10;
Console.WriteLine($"Второе число равно {digit}");
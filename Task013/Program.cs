Console.Write("Введите любое целое чиисло от 1 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = (number / 100);
if (digit > 0)
    Console.WriteLine($"Третья цифра введенного числа равна: {digit}");
else
    Console.WriteLine($"Вы ввели двузначное число, поэтому третьей цифры нет");
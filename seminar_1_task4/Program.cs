// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());

int max = firstDigit;
if (firstDigit > max ) max = firstDigit;
if ( secondDigit > max ) max = secondDigit;
if ( threeDigit > max ) max = threeDigit;

Console.Write("Максимальное число из трех это: ");
Console.Write( max );
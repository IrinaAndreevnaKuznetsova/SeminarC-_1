Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int max = firstDigit;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit  +  " больше чем " + secondDigit);
}

else 
{
Console.WriteLine (firstDigit  + " меньше чем " + secondDigit);
}


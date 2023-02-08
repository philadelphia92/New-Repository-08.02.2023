// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int number=12345;
int sumDigit=0;
System.Console.Write($"Сумма цифр числа {number} = ");
while (number>0)
{
    int digit=number%10;
    sumDigit=sumDigit+digit;
    number=number/10;
}
System.Console.WriteLine(sumDigit);
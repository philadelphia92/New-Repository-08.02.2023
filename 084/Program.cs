// 64. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

System.Console.Write("Введите число: ");
string str = Console.ReadLine();
char[] s1 = str.ToCharArray();
int j = 0;
for(int i = 0; i<s1.Length;i++)
{
    if(char.IsDigit(s1[i])) j++; 
}

if(j == s1.Length)
{
    System.Console.WriteLine($"{str} является целым числом");
    int digit = Int32.Parse(str);
    System.Console.WriteLine(SumDigit(digit));
}
else System.Console.WriteLine("Введённые данные не являются целым числом");

int SumDigit(int x)
{
    int sum = 0;
    while(x>0)
    {
        sum += x%10;
        x /= 10;
    }
    return sum;
}
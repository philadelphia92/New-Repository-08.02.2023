// 36. Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите число - ");
string write=Console.ReadLine();
int N=Convert.ToInt32(write);
int NumbersComposition(int a)
{
    int compos=1;
    for(int num=1; num<=a; num++)
    {
        compos=compos*num;
    }
    return compos;
}
System.Console.WriteLine($"Произведение чисел от 1 до {N} = {NumbersComposition(N)}");
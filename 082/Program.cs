// 62. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

Console.Write("Введите значение: ");
string str = Console.ReadLine();
int j = 0;
foreach(char q in str)
{
    if(q != '.') j++;
    else break;
}
if(j == str.Length)
    System.Console.WriteLine("В строке нет точки");
else
    System.Console.WriteLine($"Количество символов до точки: {j}");
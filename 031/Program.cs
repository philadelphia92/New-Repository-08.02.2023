// 31. Вывести на экран кубы чисел от 1 до N

int a = 12345;
int b = 123;
 
int c = (int) Math.Pow(a, 1.0/3.0);
int i3;
for (int i = c; (i3 = i * i * i) >= b; i--)
   Console.WriteLine($"{i}^3 = {i3}");
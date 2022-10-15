Console.WriteLine("Введите число:");
double a = Convert.ToDouble(Console.ReadLine());
double c, b , d;
b = Math.Pow(a, 2);
c = Math.Pow(a, 3);
d = Math.Pow(a, 4);
Console.WriteLine($"{a} в квадрате равно {b}, в кубе {c}, в четвертой степени {d}");
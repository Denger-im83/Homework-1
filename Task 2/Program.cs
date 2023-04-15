Console.Write("введите число a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("введите число b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("введите число c: ");
double c = double.Parse(Console.ReadLine());

Console.Write(" Максимальное число из трех:" + Math.Max(a, Math.Max(b,c)));

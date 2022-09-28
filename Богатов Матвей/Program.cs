// Богатов Матвей группа 22-ИСП-2/2 Вариант 23
try
{
    Console.Write("Введите x:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    Console.ForegroundColor = ConsoleColor.White;
    double y = double.Parse(Console.ReadLine());
    double res = Math.Pow(3, x) - (4 * x) + (y - Math.Sqrt(Math.Abs(x)));
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

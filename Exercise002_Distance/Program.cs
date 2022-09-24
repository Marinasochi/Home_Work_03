static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
}

static void Distance3D()
{
    try
    {
        Console.WriteLine("  Введите координаты первой точки: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double z1 = double.Parse(Console.ReadLine());
        Console.WriteLine("  Введите координаты второй точки: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double z2 = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между данными точками: {Math.Round(distance, 2)}");
    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Это не число!"); Console.ResetColor();
        Distance3D();
    }
}
emptyString(6);
string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
Console.WriteLine("    Задача 2");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Напишите программу, которая принимает \r\nна вход координаты двух точек и \r\nнаходит расстояние между ними в 3D пространстве.");
emptyString(1);
Distance3D();
Console.WriteLine(text);
emptyString(6);


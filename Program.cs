//  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Clear();
Console.Write("Введите координаты точки Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();

if (x == 0  || y == 0) Console.WriteLine("Точка лежит на оси.");

else if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами {x},{y} лежит на первой четверти.");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами {x},{y} лежит на второй четверти.");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами {x},{y} лежит на третьей четверти.");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами {x},{y} лежит на четвертой четверти.");
}

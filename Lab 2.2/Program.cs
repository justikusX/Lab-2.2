
// Ввод координат трех вершин
Console.WriteLine("Введите координаты трех вершин прямоугольника:");
Console.Write("x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("x3: ");
int x3 = int.Parse(Console.ReadLine());
Console.Write("y3: ");
int y3 = int.Parse(Console.ReadLine());

// Определяем координаты четвертой вершины
int x4 = GetFourthCoordinate(x1, x2, x3);
int y4 = GetFourthCoordinate(y1, y2, y3);

Console.WriteLine($"Координаты четвертой вершины: ({x4}, {y4})");

int GetFourthCoordinate(int a, int b, int c)
{
if (a == b)
    return c;
else if (a == c)
    return b;
else
    return a;
}
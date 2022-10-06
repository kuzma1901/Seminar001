// Задача 20
// Расстояние в 2D

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numAY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numBY = Convert.ToInt32(Console.ReadLine());

double LenghtLine (int ax, int ay, int bx, int by)
{
    if (ay == by && ax == bx) return 0;
    int x = bx - ax;
    int y = by - ay;
    return Math.Sqrt (x*x + y*y);
}
double lenghtAB = LenghtLine(numAX, numAY, numBX, numBY);
double lenght = Math.Round(lenghtAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"расстояние между A, B -> {lenght}");
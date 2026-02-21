
using System.Drawing;

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());


Console.WriteLine(CalculateRectangleArea(width, length));
static int CalculateRectangleArea(int width, int length)
{
    int calculatedArea = width * length;
    return calculatedArea;
} 
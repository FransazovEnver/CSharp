
int baseNumber = int.Parse(Console.ReadLine());
int powerNumber = int.Parse(Console.ReadLine());

Console.WriteLine(PrintMathPower(baseNumber, powerNumber));

static int PrintMathPower(int number, int power)
{
    int result = 0;
    result = (int)Math.Pow(number, power);

    return result;
}
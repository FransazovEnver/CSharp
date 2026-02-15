int pyramidNumber = int.Parse(Console.ReadLine());
int currentNumber = 1;

int number = 1;
while (number <= pyramidNumber)
{
    int intNumber = 1;
    while (intNumber <= number)
    {
        Console.Write(currentNumber + " ");
        currentNumber++;
        if (currentNumber > pyramidNumber)
        {
            break;
        }
        intNumber++;
    }
    Console.WriteLine();
    if (currentNumber > pyramidNumber)
    {
        break;
    }
    number++;
}
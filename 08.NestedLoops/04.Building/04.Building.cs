int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());


int numberOfFloors = floors;
while (numberOfFloors >= 1)
{
    int type = 0;
    while (type < estates)
    {
        if (numberOfFloors == floors)
        {
            Console.Write($"L{numberOfFloors}{type} ");
        }
        else if (numberOfFloors % 2 == 0)
        {
            Console.Write($"O{numberOfFloors}{type} ");
        }
        else 
        {
            Console.Write($"A{numberOfFloors}{type} ");
        }

        type++;
    }
    numberOfFloors--;
    Console.WriteLine();
}


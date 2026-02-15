
string destination = Console.ReadLine();


while (destination != "End")
{
    double neededBudget = double.Parse(Console.ReadLine());
    double sum = 0;

    while (sum < neededBudget)
    {
        sum += double.Parse(Console.ReadLine());
        Console.WriteLine($"Collected: {sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}




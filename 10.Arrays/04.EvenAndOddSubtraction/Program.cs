
int[] arrNumber = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int odd = 0;
int even = 0;

foreach (int number in arrNumber)
{

    if (number % 2 == 0)
    {
        even += number;
    }
    else 
    {
        odd += number;
    }
}

Console.WriteLine(even - odd);

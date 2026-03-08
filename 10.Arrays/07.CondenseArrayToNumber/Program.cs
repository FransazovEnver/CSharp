
int[] mainArray = Console.ReadLine()
                      .Split(" ")
                      .Select(int.Parse)
                      .ToArray();

while (mainArray.Length > 1)
{
    int[] condenseArray = new int[mainArray.Length - 1];

    for (int i = 0; i < mainArray.Length - 1; i++)
    {
        int currSum = mainArray[i] + mainArray[i + 1];
        condenseArray[i] = currSum;
    }

    mainArray = condenseArray;
}

Console.WriteLine(mainArray[0]);
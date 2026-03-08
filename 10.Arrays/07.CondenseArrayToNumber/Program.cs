
int[] mainArray = Console.ReadLine()
                      .Split(" ")
                      .Select(int.Parse)
                      .ToArray();


while (mainArray.Length > 1)
{
    //second array who take "- 1 index" from main array
    int[] condenseArray = new int[mainArray.Length - 1];

    //For loop who sum array indexes  
    for (int i = 0; i < mainArray.Length - 1; i++)
    {
        //sum index by index 
        int currSum = mainArray[i] + mainArray[i + 1];

        //second array take a sum value
        condenseArray[i] = currSum;
    }
    //make a main array in small array to become one index and print
    mainArray = condenseArray;
}

Console.WriteLine(mainArray[0]);

int[] numbresArray = Console.ReadLine()
                      .Split(" ")
                      .Select(int.Parse)
                      .ToArray();


int controlNumber = int.Parse(Console.ReadLine());


for (int i = 0; i < numbresArray.Length - 1; i++)
{
    int currentElement = numbresArray[i];
    for (int j = i + 1; j < numbresArray.Length ; j++)
    {
        int nextElement = numbresArray[j];
        if (currentElement + nextElement == controlNumber)
        {
            Console.WriteLine(currentElement + " " + nextElement);
            break;
        }
    }
}
                      
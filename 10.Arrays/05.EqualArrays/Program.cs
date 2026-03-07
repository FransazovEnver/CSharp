
int[] firstArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
int[] secondArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


bool areEqual = true;
if (firstArr.Length == secondArr.Length)
{
    for (int i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i] != secondArr[i])
        {
            areEqual = false;
            break;
        }
    }

}
else
{
    areEqual = false;
    Console.WriteLine("Arrays are not identical.");
}



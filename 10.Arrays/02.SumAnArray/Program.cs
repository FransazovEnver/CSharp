
int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int sum = number.Sum();

/*
for (int i = 0; i < number.Length; i++)
{
    sum += number[i];
}
*/
Console.WriteLine(sum);



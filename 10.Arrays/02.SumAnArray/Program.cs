
int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    sum += number[i];
}

Console.WriteLine(sum);


int[] number = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int sum = 0;

//int sum = number.Sum(); solution with method 

for (int i = 0; i < number.Length; i++)
{
    sum += number[i];
}

Console.WriteLine(sum);



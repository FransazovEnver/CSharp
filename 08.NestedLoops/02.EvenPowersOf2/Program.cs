
int n = int.Parse(Console.ReadLine());

int number = 0;
while (number <= n)
{
    Console.WriteLine(Math.Pow(2, number));
    number += 2;
}
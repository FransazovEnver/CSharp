
int sizeOfTriangle = int.Parse(Console.ReadLine());

for (int row = 1; row <= sizeOfTriangle; row++)
{
	for (int col = 1; col <= row; col++)
	{
        Console.Write("*");
	}
	Console.WriteLine();
}


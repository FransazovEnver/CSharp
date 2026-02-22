
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int firstFactoriel = Findfactoriel(firstNumber);
int secondFactoriel = Findfactoriel(secondNumber);

int result = firstFactoriel / secondFactoriel;

Console.WriteLine(result);

static int Findfactoriel(int number)
{
    int factoriel = 1;

    for (int i = number; i >= 1; i--)
    {
        factoriel *= i;
    }

    return factoriel;
}


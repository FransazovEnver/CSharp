
string text = Console.ReadLine();

PrintCountVowel(text);
static void PrintCountVowel(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char currentLetter = text[i];

        switch (currentLetter)
        {
            case 'a': count++; break;
            case 'A': count++; break;
            case 'i': count++; break;
            case 'I': count++; break;
            case 'o': count++; break;
            case 'O': count++; break;
            case 'e': count++; break;
            case 'E': count++; break;
            case 'u': count++; break;
            case 'U': count++; break;
        }
    }
    Console.WriteLine(count);
}


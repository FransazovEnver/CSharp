string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

RepeatCount(text,count);

Console.WriteLine(RepeatCount(text, count));

static string RepeatCount(string text, int count)
{

    string result = "";
    for (int i = 1; i <= count; i++)
    {
        result += text; 
    }

    return result;
}

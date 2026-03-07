
int dayOfWeek = int.Parse(Console.ReadLine());

string[] arraysDayOfweek = new string[7] {

    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday",
};

if (dayOfWeek >= 1 && dayOfWeek <= 7)
{
    Console.WriteLine(arraysDayOfweek[dayOfWeek - 1]);
}
else
    Console.WriteLine("Invalid day!");
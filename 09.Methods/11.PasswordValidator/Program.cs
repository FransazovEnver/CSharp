

using System.Text.RegularExpressions;

string password = Console.ReadLine();

if (PasswordShouldContainSixtoTenCharacters(password)
    && PasswordShouldContainOnlyLettersAndDigits(password)
    && PasswordShouldcontainAtLeastTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}


if (!PasswordShouldContainSixtoTenCharacters(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!PasswordShouldContainOnlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!PasswordShouldcontainAtLeastTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}



static bool PasswordShouldContainSixtoTenCharacters(string pass)
{
    if (pass.Length >= 6 && pass.Length <= 10)
    {
        return true;
    }
    else
        return false;
}

static bool PasswordShouldContainOnlyLettersAndDigits(string pass)
{
    if (Regex.IsMatch(pass, @"^[a-zA-Z0-9]+$"))
    {
        return true;
    }
    else
        return false;
}

static bool PasswordShouldcontainAtLeastTwoDigits(string pass)
{
    if (Regex.IsMatch(pass, @"\d{2}"))
         return true;
    else
        return false;
        
}


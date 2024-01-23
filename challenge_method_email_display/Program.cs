string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";


void printEmail(string[,] names, string domain = "conosto.com")
{
    for (int i = 0; i < names.GetLength(0); i++)
    {
        string userName = (names[i, 0][..2] + names[i, 1]).ToLower();
        Console.WriteLine($"{userName}@{domain}");
    }
}

printEmail(corporate);
printEmail(external, externalDomain);

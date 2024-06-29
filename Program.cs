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


for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}


// CorporateEmailAdressMaker(corporate);

// void CorporateEmailAdressMaker(string[,] employees, string domain = "contoso.com")
// {
//     string employeeFirstTwoLetters = "";
//     string lastName = "";

//     for (int i = 0; i < employees.GetLength(0); i++)
//     {
//         int test = employees.GetLength(0);
//         employeeFirstTwoLetters = employees[i, 0].Substring(0, 2);
//         lastName = employees[i, 1];
//         string email = employeeFirstTwoLetters + lastName + '@' + domain;
//         Console.WriteLine(email);

//     }

// }
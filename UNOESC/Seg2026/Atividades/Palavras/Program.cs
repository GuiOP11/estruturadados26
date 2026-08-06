string firstName = "Bilbo";
string lastName = "Bolseiro";

string note = lastName.ToUpper()
        + "" + firstName;

string initials = lastName[0] + " "
                +   firstName[0];

Console.WriteLine ("" + initials);

// formatation to string

string texto = string.Format (
    "{0} {1} nascido em {2}",
    firstName,
    lastName,
    "1984"
);

Console.WriteLine (texto);


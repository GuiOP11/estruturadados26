// Classe Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public CountryEnum Nationality { get; set; }
}

// Enum = Enumerador
public enum CountryEnum
{
    BR,
    US,
    AR,
    PY
}
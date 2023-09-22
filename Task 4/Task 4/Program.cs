string name = ("Ewa");
string sex = ("Woman");
var age = 33;

if (age == 33 && sex == "Woman" && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age < 30 && sex == "Woman")
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (age < 18 && sex != "Woman")
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Niezidentyfikowana osoba.");
}
Console.WriteLine("Zadanie 7");
Console.WriteLine("Podaj wiek:");
string age = Console.ReadLine();
int ageUser = int.Parse(age);

if (ageUser < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (ageUser >= 0 && ageUser <= 12)
{
    Console.WriteLine("Dziecko");
}
else if (ageUser >= 13 && ageUser <= 17)
{
    Console.WriteLine("Nastolatek");
}
else if (ageUser >= 18 && ageUser <= 64)
{
    Console.WriteLine("Osoba dorosła");
}
else
{
    Console.WriteLine("Senior");
}

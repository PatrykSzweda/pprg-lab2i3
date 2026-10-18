Console.WriteLine("Zadanie 8");
Console.WriteLine("Podaj punkty życia:");
string health = Console.ReadLine();
int healthPoints = int.Parse(health);
Console.WriteLine("Czy ma klucz?");
string key = Console.ReadLine();
bool haveKey = bool.Parse(key);
Console.WriteLine("Czy zna hasło?");
string password = Console.ReadLine();
bool havePassword = bool.Parse(password);

if (healthPoints <= 0)
{
    Console.WriteLine("Nie możesz wejść, ponieważ nie żyjesz");
}
else if (haveKey == true || havePassword == true)
{
    Console.WriteLine("Możesz wejść");
}
else
{
    Console.WriteLine("Nie możesz wejść, ponieważ nie masz sposobu otwarcia drzwi");
}
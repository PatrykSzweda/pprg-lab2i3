Console.WriteLine("Zadanie 4");
Console.WriteLine("Podaj punkty życia:");
string health = Console.ReadLine();
int healthPoints = int.Parse(health);
Console.WriteLine("Podaj liczbę mikstur:");
string potions = Console.ReadLine();
int potionAmount = int.Parse(potions);
Console.WriteLine("Czy ma klucz?");
string klucz = Console.ReadLine();
bool maKlucz = bool.Parse(klucz);
Console.WriteLine("Czy ma mapę?");
string mapa = Console.ReadLine();
bool maMape = bool.Parse(mapa);
bool zyje;
if (healthPoints > 0)
{
    zyje = true;
} 
else zyje = false;
bool maPelneZdrowie;
if (healthPoints == 100)
{
    maPelneZdrowie = true;
}
else maPelneZdrowie = false;
bool maZaopatrzenie;
if (potionAmount > 0)
{
    maZaopatrzenie = true;
}
else maZaopatrzenie = false;
bool maPrzedmiotNawigacyjny;
if (maKlucz == true || maMape == true)
{
    maPrzedmiotNawigacyjny = true;
}
else maPrzedmiotNawigacyjny = false;
bool gotowyDoWyprawy;
if (zyje == true && maZaopatrzenie == true && maPrzedmiotNawigacyjny == true)
{
    gotowyDoWyprawy = true;
}
else gotowyDoWyprawy = false;
bool wymagaLeczenia;
if (!maPelneZdrowie)
{
    wymagaLeczenia = true;
}
else wymagaLeczenia = false;
Console.WriteLine($"Żyję: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");
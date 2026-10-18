Console.WriteLine("Zadanie 5");
Console.WriteLine("Podaj liczbę całkowitą:");
string number = Console.ReadLine();
int numberEven = int.Parse(number);
int rest = numberEven % 2;
if (rest == 0)
{
    Console.WriteLine("Liczba jest parzysta");
}
else Console.WriteLine("Liczba jest nieparzysta");
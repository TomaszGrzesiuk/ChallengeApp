// deklaracja zmiennej imie typ string
string imie = "Ewa";
// deklaracja zmiennej plec
bool toKobieta = true;
// deklaracja wieku
int wiek = 18;


if (toKobieta == true)
{
    Console.WriteLine("Dziewczyna");

    if (imie == "Ewa")
    {
        Console.WriteLine("ma na imię Ewa");
        if (wiek >= 18)
        {
            Console.WriteLine("Dorosły");
        }
        else
        {
            Console.WriteLine("Dziecko");
        }
    }
    else
    {
        Console.WriteLine("nie ma na imię Ewa");
        if (wiek >= 18)
        {
            Console.WriteLine("Dorosły");
        }
        else
        {
            Console.WriteLine("Dziecko");
        }
    }
}
else
{
    Console.WriteLine("Chłopak");
    if (wiek >= 18)
    {
        Console.WriteLine("Dorosły");
    }
    else
    {
        Console.WriteLine("Dziecko");
    }
}
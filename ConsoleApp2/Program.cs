/*
    Console.WriteLine("Ahoj, právě si vybírám číslo....");

int cislo = new Random().Next(1, 11);
int pocetPokusu = 0;

Console.WriteLine("Zkus uhádnout, jaké číslo jsem si vybral. Zadej číslo:");

int zadaneCislo = Convert.ToInt32(Console.ReadLine());
pocetPokusu++;

while (zadaneCislo != cislo)
{
    if (zadaneCislo < cislo)
    {
        Console.WriteLine("Moc nízké číslo, zkus to znovu:");
    }
    else
    {
        Console.WriteLine("Moc vysoké číslo, zkus to znovu:");
    }

    zadaneCislo = Convert.ToInt32(Console.ReadLine());
    pocetPokusu++;
}

Console.WriteLine("Gratuluji, uhodl jsi číslo!");
Console.WriteLine("Počet pokusů: " + pocetPokusu);





Console.WriteLine("Zadej svůj rok narození:");
int rok_narozeni = Convert.ToInt32(Console.ReadLine());


int moje_funkce(int rok_narozeni)
{ int aktualni_rok = DateTime.Now.Year;
return aktualni_rok - rok_narozeni;
}



Console.WriteLine("Zadej své jméno:");
string name = Console.ReadLine();

Console.WriteLine("Zadej své příjmení:");
string surname = Console.ReadLine();

string fullname(string name, string surname)
{
    return name + " " + surname;
}
Console.WriteLine("Tvoje jméno a příjmení je: " + fullname(name, surname));

 
 */



Console.WriteLine("Zadej první číslo:");
int cislo1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Zadej druhé číslo:");
int cislo2 = Convert.ToInt32(Console.ReadLine());


string co_je_vetsi(int cislo1, int cislo2)
{
    if (cislo1 > cislo2)
    {
        return cislo1;
    }
    else
    {
        return cislo2;
    }
}

Console.WriteLine("Větší číslo je: " + co_je_vetsi(cislo1, cislo2));
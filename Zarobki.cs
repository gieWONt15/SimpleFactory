namespace zadanie_3;

public class Zarobki : IPlatnosci
{
    public void Platnosci()
    {
        bool poprawneBrutto;
        decimal brutto;
        do
        {
            Console.Write("Podaj kwotę brutto: ");
            poprawneBrutto = decimal.TryParse(Console.ReadLine(), out brutto);

            if (!poprawneBrutto)
            {
                Console.WriteLine("Niepoprawna kwota brutto, spróbuj jeszcze raz.");
            }
        } while (!poprawneBrutto);

        decimal emerytalna = brutto * 0.0976m;
        decimal rentowa = brutto * 0.015m;
        decimal chorobowa = brutto * 0.0245m;
        decimal zusRazem = emerytalna + rentowa + chorobowa;

        decimal podstawaZdrowotne = brutto - zusRazem;

        decimal zdrowotne = podstawaZdrowotne * 0.09m;
        decimal zdrowotneOdliczane = podstawaZdrowotne * 0.0775m;

        decimal kosztyUzyskania = 250.00m;

        decimal podstawaOpodatkowania = brutto - zusRazem - kosztyUzyskania;
        decimal podstawaZaokrąglona = Math.Floor(podstawaOpodatkowania);

        decimal zaliczkaPodatek = podstawaZaokrąglona * 0.17m - 300.00m;

        decimal podatekDoZaplaty = zaliczkaPodatek - zdrowotneOdliczane;
        if (podatekDoZaplaty < 0) podatekDoZaplaty = 0;

        decimal netto = brutto - zusRazem - zdrowotne - podatekDoZaplaty;

        Console.WriteLine($"\nWynagrodzenie netto: {netto:F2} zł");
        Console.WriteLine($"Suma składek ZUS: {zusRazem:F2} zł");
        Console.WriteLine($"Składka zdrowotna: {zdrowotne:F2} zł");
        Console.WriteLine($"Zaliczka na podatek: {podatekDoZaplaty:F2} zł");
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
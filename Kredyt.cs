namespace zadanie_3;

public class Kredyt : IPlatnosci
{
    public void Platnosci()
    {
        bool poprawnaKwotaKredytu;
        bool poprawneRoczneOprocentowanie;
        bool poprawnaLiczbaRat;

        double kwotaKredytu;
        double roczneOprocentowanie;
        int liczbaRat;
        
        Console.WriteLine("Oblicz ratę swojego kredytu");

        do
        {
            Console.WriteLine("Podaj kwotę kredytu");
            poprawnaKwotaKredytu = double.TryParse(Console.ReadLine() ?? string.Empty, out kwotaKredytu);

            if (!poprawnaKwotaKredytu || kwotaKredytu < 0)
            {
                Console.WriteLine("Niepoprawna kwota kredytu, spróbuj ponownie");
            }
        } while (!poprawnaKwotaKredytu);

        do
        {
            Console.WriteLine("Podaj roczne oprocentowanie (np. 0,08)");
            poprawneRoczneOprocentowanie = double.TryParse(Console.ReadLine() ?? string.Empty, out roczneOprocentowanie);

            if (!poprawneRoczneOprocentowanie || roczneOprocentowanie < 0)
            {
                Console.WriteLine("Niepoprawne roczne oprocentowanie, spróbuj ponownie");
            }
        } while (!poprawneRoczneOprocentowanie);

        do
        {
            Console.WriteLine("Podaj liczbę rat swojego kredytu");
            poprawnaLiczbaRat = int.TryParse(Console.ReadLine() ?? string.Empty, out liczbaRat);

            if (!poprawnaLiczbaRat || liczbaRat < 0)
            {
                Console.WriteLine("Niepoprawna liczba rat, spróbuj ponownie");
            }
        } while (!poprawnaLiczbaRat);
        
        double miesieczneOprocentowanie = roczneOprocentowanie / 12;
        double q = 1 + miesieczneOprocentowanie;
        double rata = kwotaKredytu * Math.Pow(q, liczbaRat) * (q - 1) / (Math.Pow(q, liczbaRat) - 1);

        Console.WriteLine($"Rata twojego kredytu: {Math.Round(rata, 2)}");
        
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
namespace zadanie_3;

public class PodatekDochodowy : IPlatnosci
{
    public void Platnosci()
    {
        bool poprawnyDochod;
        decimal dochod;

        do
        {
            Console.Write("Podaj swój dochód roczny (po odliczeniu kosztów uzyskania): ");
            poprawnyDochod = decimal.TryParse(Console.ReadLine(), out dochod);

            if (!poprawnyDochod)
            {
                Console.WriteLine("Niepoprawny dochód, spróbuj ponownie.");
            }
        } while (!poprawnyDochod);
        
        
        decimal kwotaWolna = 30000m;
        decimal prog = 120000m;
        decimal zmniejszeniePodatku = 3600m;

        decimal podatek = 0;

        if (dochod <= kwotaWolna)
        {
            podatek = 0;
        }
        else
        {
            decimal podstawaOpodatkowania = dochod - kwotaWolna;

            if (dochod <= prog)
            {
                podatek = podstawaOpodatkowania * 0.17m;
                podatek -= zmniejszeniePodatku; 
            }
            else
            {
                decimal nadwyzka = dochod - prog;
                podatek = (prog - kwotaWolna) * 0.17m + nadwyzka * 0.32m;
                podatek -= zmniejszeniePodatku;
            }

            if (podatek < 0)
            {
                podatek = 0;
            }
        }

        Console.WriteLine($"Podatek dochodowy do zapłaty: {podatek:F2} zł");
        
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
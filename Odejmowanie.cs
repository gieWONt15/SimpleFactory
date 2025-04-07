namespace zadanie_3;

public class Odejmowanie : IPlatnosci
{
    public void Platnosci()
    {
        Console.WriteLine("Platnosci typ 2!");
        Console.WriteLine("Podaj liczbę (0, aby zakończyć): ");

        decimal roznica;

        roznica = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Podaj koleją liczbę");

        while (true)
        {
            var input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal number))
            {
                if (number == 0)
                {
                    Console.WriteLine($"Różnica wszystkich liczb: {roznica}");
                    break;
                }

                roznica -= number;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie.");
            }

            Console.WriteLine("Podaj kolejną liczbę");
        }
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
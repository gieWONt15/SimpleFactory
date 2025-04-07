namespace zadanie_3;

public class Iloraz : IPlatnosci
{
    public void Platnosci() {
        Console.WriteLine("Iloraz"); 
        Console.WriteLine("Podaj liczbę (0, aby zakończyć): ");
        
        var iloraz = decimal.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Podaj kolejną liczbę");

        while (true)
        {
            var input = Console.ReadLine();

            if (decimal.TryParse(input, out var number))
            { 
                if (number == 0) 
                { 
                    Console.WriteLine($"Iloraz wszystkich liczb: {iloraz}"); 
                    break;
                }
                
                iloraz /= number;
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
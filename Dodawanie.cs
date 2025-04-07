namespace zadanie_3;

public class Dodawanie : IPlatnosci
{
    public void Platnosci()
    {
        Console.WriteLine("Platnosci typ 1!");
        Console.WriteLine("Podaj liczbę (0, aby zakończyć): ");
        decimal suma = 0;
        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                if (number == 0)
                {
                    Console.WriteLine($"Suma wszystkich liczb: {suma}");
                    break;
                }

                suma += number;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie.");
            }

            Console.WriteLine("Podaj następną liczbę");
        }
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
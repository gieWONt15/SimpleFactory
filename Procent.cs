namespace zadanie_3;

public class Procent : IPlatnosci
{
    public void Platnosci()
    {
        bool poprawnyInput;
        bool poprawnyProcent;
        Console.WriteLine("Procent z liczby");

        decimal num;
        decimal procent;
        
        do
        {
            Console.WriteLine("Podaj liczbę bazową");
            poprawnyInput = decimal.TryParse(Console.ReadLine(), out num);

            if (!poprawnyInput)
            {
                Console.WriteLine("Niepoprawna liczba, spróbuj ponownie");
            }
        } while (!poprawnyInput);

        do
        {
            Console.WriteLine("Podaj procent z liczby bazowej, jaki chcesz obliczyć.");
            poprawnyProcent = decimal.TryParse(Console.ReadLine(), out procent);

            if (!poprawnyProcent)
            {
                Console.WriteLine("Niepoprawny procent, spróbuj ponownie");
            }
        } while (!poprawnyProcent);

        Console.WriteLine($"{procent}% z liczby {num} wynosi: {num/100*procent}");
        
        Console.WriteLine();
        
        Console.WriteLine("Naciśnij dowolny przycisk, aby wrócić do menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
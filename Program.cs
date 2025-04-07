namespace zadanie_3;

public class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Witaj w aplikacji do obsługi obliczeń matematycznych!");
            Console.WriteLine("Wybierz co chcesz obliczyć. [0-9], 0 pozwoli wyjść z programu");
            Console.WriteLine();
            Console.WriteLine("1. Suma (dodawanie)");
            Console.WriteLine("2. Różnica (odejmowanie)");
            Console.WriteLine("3. Iloraz (dzielenie)");
            Console.WriteLine("4. Iloczyn (mnożenie)");
            Console.WriteLine("5. Procent z liczby");
            Console.WriteLine("6. Kalkulacja rat kredytu");
            Console.WriteLine("7. Kalkulacja zarobków netto");
            Console.WriteLine("8. Prognozy inwestycyjne");
            Console.WriteLine("9. Wyliczenie podatku dochodowego");
            Console.WriteLine("0. Zamknij program");
            Console.WriteLine();

            var input = Console.ReadLine();
            Console.Clear();

            if (input == "0")
            {
                Console.WriteLine("Zamykanie programu...");
                break;
            }

            if (input == null) continue;

            var platnosci = PlatnosciFactory.CreatePlatnosci(input);
            platnosci.Platnosci();
        }
    }
}
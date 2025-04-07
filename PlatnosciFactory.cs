namespace zadanie_3;

class PlatnosciFactory
{
    public static IPlatnosci CreatePlatnosci(string typ)
    {
        switch (typ.ToLower())
        {
            case "1":
                return new Dodawanie();
            case "2": 
                return new Odejmowanie();
            case "3": 
                return new Iloraz();
            case "4":
                return new Iloczyn();
            case "5":
                return new Procent();
            case "6":
                return new Kredyt();
            case "7":
                return new Zarobki();
            case "8":
                return new Inwestycje();
            case "9":
                return new PodatekDochodowy();
        }

        return null!;
    }
}
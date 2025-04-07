# Aplikacja do obsługi obliczeń matematycznych

## Opis
Aplikacja konsolowa umożliwiająca wykonywanie różnych obliczeń matematycznych, takich jak dodawanie, odejmowanie, mnożenie, dzielenie, obliczanie procentów, kalkulacja rat kredytu, kalkulacja zarobków netto, prognozy inwestycyjne oraz wyliczenie podatku dochodowego.

## Funkcjonalności
- **Dodawanie**: Oblicza sumę wprowadzonych liczb.
- **Odejmowanie**: Oblicza różnicę wprowadzonych liczb.
- **Mnożenie**: Oblicza iloczyn wprowadzonych liczb.
- **Dzielenie**: Oblicza iloraz wprowadzonych liczb.
- **Procent z liczby**: Oblicza procent z podanej liczby.
- **Kalkulacja rat kredytu**: Oblicza miesięczną ratę kredytu na podstawie podanej kwoty, oprocentowania i liczby rat.
- **Kalkulacja zarobków netto**: Oblicza wynagrodzenie netto na podstawie podanej kwoty brutto.
- **Prognozy inwestycyjne**: (Funkcja w trakcie implementacji)
- **Wyliczenie podatku dochodowego**: Oblicza podatek dochodowy na podstawie podanego dochodu rocznego.

## Jak uruchomić
1. Sklonuj repozytorium:
    ```sh
    git clone github.com/gieWONt15/SimpleFactory
    ```
2. Otwórz projekt w IDE (np. JetBrains Rider).
3. Uruchom aplikację.

## Wymagania
- .NET 6.0 lub nowszy

## Struktura projektu
- `Program.cs`: Główny plik uruchamiający aplikację.
- `PlatnosciFactory.cs`: Fabryka tworząca obiekty odpowiednich klas obliczeniowych.
- `Dodawanie.cs`, `Odejmowanie.cs`, `Iloczyn.cs`, `Iloraz.cs`, `Procent.cs`, `Kredyt.cs`, `Zarobki.cs`, `PodatekDochodowy.cs`, `Inwestycje.cs`: Klasy implementujące interfejs `IPlatnosci` dla poszczególnych typów obliczeń.

## Autor
- Paweł Gierlotka

## Licencja
Ten projekt jest licencjonowany na warunkach licencji MIT.

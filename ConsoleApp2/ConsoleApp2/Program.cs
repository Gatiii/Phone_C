using System;
using System.Collections.Generic;

// Klasa reprezentująca kontakt
class Kontakt
{
    public string Imie { get; set; }
    public string NumerTelefonu { get; set; }

    public Kontakt(string imie, string numerTelefonu)
    {
        Imie = imie;
        NumerTelefonu = numerTelefonu;
    }
}

// Klasa reprezentująca zarządzanie kontaktami
class ZarzadzanieKontaktami
{
    private List<Kontakt> listaKontaktow;

    public ZarzadzanieKontaktami()
    {
        listaKontaktow = new List<Kontakt>();
    }

    public void DodajKontakt()
    {
        Console.WriteLine("Podaj imię kontaktu:");
        string imie = Console.ReadLine();
        Console.WriteLine("Podaj numer telefonu kontaktu:");
        string numerTelefonu = Console.ReadLine();

        Kontakt nowyKontakt = new Kontakt(imie, numerTelefonu);
        listaKontaktow.Add(nowyKontakt);

        Console.WriteLine("Kontakt został dodany.");
    }

    public void ZnajdzKontakt()
    {
        Console.WriteLine("Podaj imię kontaktu do wyszukania:");
        string imie = Console.ReadLine();

        Kontakt znalezionyKontakt = listaKontaktow.Find(k => k.Imie.Equals(imie));

        if (znalezionyKontakt != null)
        {
            Console.WriteLine("Znaleziono kontakt:");
            Console.WriteLine($"Imię: {znalezionyKontakt.Imie}");
            Console.WriteLine($"Numer telefonu: {znalezionyKontakt.NumerTelefonu}");
        }
        else
        {
            Console.WriteLine("Kontakt nie został znaleziony.");
        }
    }

    public void UsunKontakt()
    {
        Console.WriteLine("Podaj imię kontaktu do usunięcia:");
        string imie = Console.ReadLine();

        Kontakt kontaktDoUsuniecia = listaKontaktow.Find(k => k.Imie.Equals(imie));

        if (kontaktDoUsuniecia != null)
        {
            listaKontaktow.Remove(kontaktDoUsuniecia);
            Console.WriteLine("Kontakt został usunięty.");
        }
        else
        {
            Console.WriteLine("Kontakt nie został znaleziony.");
        }
    }

    public void ZastapKontakt()
    {
        Console.WriteLine("Podaj imię kontaktu do zastąpienia:");
        string imie = Console.ReadLine();

        Kontakt kontaktDoZastapienia = listaKontaktow.Find(k => k.Imie.Equals(imie));

        if (kontaktDoZastapienia != null)
        {
            Console.WriteLine("Podaj nowe imię kontaktu:");
            string noweImie = Console.ReadLine();
            Console.WriteLine("Podaj nowy numer telefonu kontaktu:");
            string nowyNumerTelefonu = Console.ReadLine();

            kontaktDoZastapienia.Imie = noweImie;
            kontaktDoZastapienia.NumerTelefonu = nowyNumerTelefonu;

            Console.WriteLine("Kontakt został zastąpiony.");
        }
        else
        {
            Console.WriteLine("Kontakt nie został znaleziony.");
        }
    }
}

// Klasa programu
class Program
{
    static void Main()
    {
        ZarzadzanieKontaktami zarzadzanieKontaktami = new ZarzadzanieKontaktami();

        bool dzialanieProgramu = true;

        while (dzialanieProgramu)
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Dodaj kontakt");
            Console.WriteLine("2. Znajdź kontakt");
            Console.WriteLine("3. Usuń kontakt");
            Console.WriteLine("4. Zastąp kontakt");
            Console.WriteLine("5. Wróć do menu");
            Console.WriteLine("6. Zakończ program");

            Console.Write("Wybierz opcję: ");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "1":
                    zarzadzanieKontaktami.DodajKontakt();
                    break;
                case "2":
                    zarzadzanieKontaktami.ZnajdzKontakt();
                    break;
                case "3":
                    zarzadzanieKontaktami.UsunKontakt();
                    break;
                case "4":
                    zarzadzanieKontaktami.ZastapKontakt();
                    break;
                case "5":
                    continue;
                case "6":
                    dzialanieProgramu = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

// Koristimo kod koji je u namespace PascalovTrokutBinomniPoucak
using PascalovTrokutBinomniPoucak;

Console.OutputEncoding = System.Text.Encoding.Unicode;
while (true)
{
    // Ovaj dio je zbog nekog čudnog buga koji se pojavi kad se vratis iz nekog moda.
    Console.Clear();
    Console.WriteLine("Clear");

    // Čistimo konzolu i ispisujemo početni tekst
    Console.Clear();
    Console.WriteLine(" [1] Pascalov Trokut");
    Console.WriteLine(" [2] Binomni Poučak");
    Console.WriteLine(" [Esc] Zatvori program");
    Console.WriteLine("\n Pritisnite odgovarajući znak za odabir");

    // Od korisnika se traži da odabere neku od navedenih opcija
    ConsoleKey key = Console.ReadKey().Key;

    // Ako je pritisnuto "1" pokreće se kod za paskalov trokut
    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
    {
        // Čistimo konzolu od početnog teksta i ispisujemo novu poruku
        Console.Clear();
        Console.Write("Broj redova: ");

        // Deklariramo varijablu za broj redova
        int brojRedova = 0;

        // Od korisnika se u while-u traži ponovni upis ukoliko broj redova nije u traženom rasponu od 1 do 13 
        while (!int.TryParse(Console.ReadLine(), out brojRedova) || brojRedova > 13 || brojRedova < 1)
        {
            // Korisnika se obavještava o rasponu i ponovno se ispisuje poruka za upis broja redova
            Console.Clear();
            Console.WriteLine("Broj redova mora biti u intervalu [1, 13]!\n");
            Console.Write("Broj redova: ");
        }


        // Kod koji se izvršava nakon što se prihvati unesen broj redova
        while (true)
        {
            // Ovaj dio je zbog nekog čudnog buga koji se pojavi kad se vratis iz nekog moda.
            Console.Clear();
            Console.WriteLine("Clear");

            // Čistimo konzolu
            Console.Clear();

            // Stvara se objekt PascalsTriangle
            PascalsTriangle pascalovTrokut = new PascalsTriangle(brojRedova);

            // Poziva se metoda za ispis traženog paskalovog trokuta
            pascalovTrokut.Print();

            // Korisniku se ispisuju nove opcije nakon ispisa trokuta
            Console.WriteLine("\n[Esc] Povratak na Izbornik  [A] Dodaj Red  [R] Makni Red  [E] Objasni");

            // Traži se unos
            key = Console.ReadKey().Key;

            // Kod koji se pokreće ako je pritisnuto "ESC"
            if (key == ConsoleKey.Escape)
            {
                // Izlazi se iz while-a i vraća se na početak koda
                break;
            }
            // Kod koji se pokreće ako je pritisnuto "A" za dodavanje jednog reda trokuta
            else if (key == ConsoleKey.A)
            {
                // Provjerava se da broj redova već nije maksimalan broj (13)
                if (brojRedova != 13)
                {
                    // Varijabli za broj redova dodajemo jedan
                    brojRedova++;
                }
            }
            // Kod koji se pokreće ako je pritisnuto "R" za oduzimanje jednog reda trokuta
            else if (key == ConsoleKey.R)
            {
                // Provjerava se da broj redova već nije minimalan broj (1)
                if (brojRedova != 1)
                {
                    // Varijabli za broj redova oduzimamo jedan
                    brojRedova--;
                }
            }
            // Kod koji se pokreće ako je pritisnuto "E" za objašnjenje
            else if (key == ConsoleKey.E)
            {
                // Kod koji se pokreće ako broj redova nije dovoljan za prikaz objašnjenja
                if(brojRedova < 4)
                {
                    // Ispisuje se poruka o minimalnom broju redova
                    Console.WriteLine("Minimalan broj redova za objašnjenje je 4. Probajte dodati još koji red.");

                    // Kod se pauzira na 3 sekunde kako bi korisnik mogao pročitati poruku
                    Thread.Sleep(3000);
                }
                // Kod koji se pokreće ako je broj redova dovoljan za prikaz objašnjenja
                else
                {
                    // Poziva se metoda za objašnjenje principa paskalovog trokuta
                    pascalovTrokut.Explain();
                }
            }
            // Nakon što smo promijenili broj redova ili završili objašnjenje vračamo se na početak while-a kako bi se ažurirao broj redova trokuta (ukoliko je promijenjen)
        }
    }

    // Ako je pritisnuto "2" pokreće se kod za prikaz binomnog poučka
    else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
    {
        // Deklariraju se potrebne varijable
        int n = 0;
        bool redo = true;

        while (true)
        {
            // Kod koji se izvrašava ako je redo TRUE
            if (redo)
            {
                // Čisti se konzola i ispisuje se opći oblik binomnog poučka
                Console.Clear();
                Console.WriteLine("(x + y)ⁿ");
                Console.Write("Odaberi n: ");
                // Od korisnika se u while-u traži ponovni upis ukoliko je upisani n nepozitivan broj
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.Clear();
                    Console.WriteLine("(x + y)ⁿ");
                    Console.Write("Odaberi n: ");
                }
                // redo se postavlja u FALSE
                redo = false;
                // Stvara se objekt binominalTheorem
                BinomialTheorem binomialTheorem = new BinomialTheorem(n);
                // Poziva se metoda za ispisivanje formule binomnog poučka za navedeni n
                Console.WriteLine(binomialTheorem.Calculate());
                // Korisniku se ispisuju opcije
                Console.WriteLine("\n[Esc] Povratak na Izbornik  [R] Ponovi sa drugačijim n");
            }
            // Traži se upis korisnika
            ConsoleKey consoleKey = Console.ReadKey().Key;
            // Kod koji se pokreće ako je pritisnuto "R" za ponavljanje poučka
            if(consoleKey == ConsoleKey.R)
            {
                // redo se postavlja u TRUE kako bi se ponovno ispisao tekst
                redo = true;
            }
            // Kod koji se pokreće ako je pritisnuto "ESC" za povratak
            else if (consoleKey == ConsoleKey.Escape)
            {
                // Izlazi se iz while-a i vraća se na početak koda
                break;
            }
        }
    }

    // Ako je pritisnuto "ESC" pokreće se kod za izlazak iz programa
    else if(key == ConsoleKey.Escape)
        // Program se završava
        return;
}
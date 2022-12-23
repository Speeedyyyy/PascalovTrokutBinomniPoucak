// Postavljamo klasu u zajednički namespace PascalovTrokutBinomniPoucak kako bi se mogla koristiti u programu
namespace PascalovTrokutBinomniPoucak
{
    public class PascalsTriangle
    {
        // Deklarira se privatna varijabla za spremanje unesenog broja redova
        private int numRows;

        // Konstruktor
        public PascalsTriangle(int numRows)
        {
            this.numRows = numRows;
        }

        // Javna metoda za ispis prikaza paskalovog trokuta
        public void Print()
        {
            // Deklarira se vrijednost za koja se koristi za ispisivanje određenog broja u trokutu
            int val = 1;
            // Petlja koja se izvršava jednom za svaki redak
            for (int i = 0; i < numRows; i++)
            {
                // Kod koji se izvršava ako smo na parnom redu
                if (i % 2 == 0)
                {
                    // Pozivamo metodu za ispisivanje prikladnog broja razmaka kako bi trokut bio centriran
                    PrintSpaces(numRows - i * 2 + 11);
                }
                // Kod koji se izvršava ako smo na neparnom redu
                else
                {
                    // Pozivamo metodu za ispisivanje prikladnog broja razmaka kako bi trokut bio centriran
                    PrintSpaces(numRows - i * 2 + 11);
                }

                // Petlja koja se izvršava za ispis svakog broja u redu
                for(int j = 0; j <= i; j++)
                {
                    // Ako je broj prvi u redu
                    if(i == 0 || j == 0)
                    {
                        // Vrijednost broja koji se ispisuje u trokutu se postavlja na 1
                        val = 1;
                    }
                    // Ako je broj na bilo kojem mjestu u redu osim na prvom
                    else
                    {
                        // Izračun vrijednosti broja koji se ispisuje u trokutu
                        val = val * (i - j + 1) / j;
                    }
                    // Ako je broj jednoznamekast
                    if(val < 10)
                    {
                        // Ispisuje se broj i 3 razmaka radi centriranja
                        Console.Write($"{val}   ");
                    }
                    // Ako je broj dvoznamekast
                    else if (val < 100)
                    {
                        // Ispisuje se broj i 2 razmaka radi centriranja
                        Console.Write($"{val}  ");
                    }
                    // Ako broj ima više od dvije znamenke
                    else
                    {
                        // Ispisuje se broj i 1 razmak
                        Console.Write($"{val} ");
                    }
                }
                // Prelazak u novi red
                Console.WriteLine();
            }
        }

        // Javna metoda za ispis objašnjena paskalovog trokuta
        public void Explain()
        {
            while (true)
            {
                // Čistimo konzolu od prethodnog teksta i ispisujemo prvi dio objašnjenja
                Console.Clear();
                Print();
                Console.WriteLine("\nPascalov trokut je trokutasti raspored brojeva koji daje koeficijente u proširenju bilo kojeg binomnog izraza, kao što je (x + y)ⁿ. Više o ovome na zadnjoj stranici.");
                Console.WriteLine("\n");
                // Korisniku se ispisuju opcije
                Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");

                // Od korisnika se traži upis
                ConsoleKey consoleKey = Console.ReadKey().Key;

                //Kod koji se izvršava ako je pritisnuto "->"
                if (consoleKey == ConsoleKey.RightArrow)
                {
                    while (true)
                    {
                        // Čistimo konzolu od prethodnog objašnjenja i ispisujemo novi dio
                        Console.Clear();
                        // Poziva se privatna metoda za ispis vizualizacije zbrajanja u trokutu
                        PrintSum();
                        Console.WriteLine("\nTrokut se može konstruirati tako da se prvo postavi 1 duž lijevog i desnog ruba. Zatim se trokut može popuniti od vrha zbrajanjem dva broja lijevo i desno od svake pozicije u trokutu (kao što je prikazano u trokutu - zeleno = crveno + crveno).");
                        Console.WriteLine("\n");
                        // Korisniku se ispisuju opcije
                        Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");

                        // Od korisnika se traži upis
                        consoleKey = Console.ReadKey().Key;

                        //Kod koji se izvršava ako je pritisnuto "->"
                        if (consoleKey == ConsoleKey.RightArrow)
                        {
                            while (true)
                            {
                                // Čistimo konzolu od prethodnog objašnjenja i ispisujemo novi dio
                                Console.Clear();
                                // Poziva se privatna metoda za ispis vizualizacije Fibonaccijevog niza u trokutu
                                PrintFibonacci();
                                Console.WriteLine("\nTrokut prikazuje mnogo zanimljivih uzoraka. Na primjer, crtanje paralelnih \"plitkih dijagonala\" i zbrajanje brojeva u svakoj liniji zajedno proizvodi Fibonaccijev niz (1, 1, 2, 3, 5, 8, 13, 21... = S(zeleno), S(crveno) , S(žuta), S(magenta), S(cijan), S(siva), S(tamnoplava) gdje je S zbroj).");
                                Console.WriteLine("\n");
                                // Korisniku se ispisuju opcije
                                Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");

                                // Od korisnika se traži upis
                                consoleKey = Console.ReadKey().Key;

                                //Kod koji se izvršava ako je pritisnuto "->"
                                if (consoleKey == ConsoleKey.RightArrow)
                                {
                                    // Čistimo konzolu od prethodnog objašnjenja i ispisujemo novi dio
                                    Console.Clear();
                                    // Poziva se privatna metoda za ispis vizualizacije povezanosti trokuta sa binomnim poučkom
                                    PrintBinomialTheoremConnection();
                                    Console.WriteLine("\nIz trokuta možemo vidjeti vezu s binomnim teoremom. Ako trokut podijelimo u retke, ono što dobivamo su koeficijenti binomnih izraza. Na primjer:");
                                    Console.WriteLine($"\t1. red [1]: (x + y){0.ToSuperscript()} = 1");
                                    Console.WriteLine($"\t2. red [1, 1]: (x + y){1.ToSuperscript()} = x + y");
                                    Console.WriteLine($"\t3. red [1, 2, 1]: (x + y){2.ToSuperscript()} = x{2.ToSuperscript()} + 2xy + y{2.ToSuperscript()}");
                                    Console.WriteLine($"\t4. red [1, 3, 3, 1]: (x + y){3.ToSuperscript()} = x{3.ToSuperscript()} + 3x{2.ToSuperscript()}y + 3xy{2.ToSuperscript()} + y{3.ToSuperscript()}");
                                    Console.WriteLine($"\t5. red [1, 4, 6, 4, 1]: (x + y){4.ToSuperscript()} = x{4.ToSuperscript()} + 4x{3.ToSuperscript()}y + 6x{2.ToSuperscript()}y{2.ToSuperscript()} + 4xy{3.ToSuperscript()} + y{4.ToSuperscript()}");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Pritisni bilo koju tipku za završetak objašnjenja.");

                                    // Od korisnika se traži upis
                                    Console.ReadKey();

                                    // Klasa se zavrsava i vrača se u program
                                    return;
                                }




                                // Kod koji se izvršava ako je pritisnuto "ESC"
                                else if (consoleKey == ConsoleKey.Escape)

                                    // Klasa se zavrsava i vrača se u program
                                    return;
                            }
                        }




                        // Kod koji se izvršava ako je pritisnuto "ESC"
                        else if (consoleKey == ConsoleKey.Escape)

                            // Klasa se zavrsava i vrača se u program
                            return;
                    }
                }




                // Kod koji se izvršava ako je pritisnuto "ESC"
                else if (consoleKey == ConsoleKey.Escape)

                    // Klasa se zavrsava i vrača se u program
                    return;
            }
        }

        // Privatna metoda koja se koristi za specifičan prikaz trokuta u objašnjenju
        // Ispisuje trokut sa unešenim brojem redova, treći i četvrti broj predzadnjeg reda se bojaju u crveno a onaj ispod njih zeleno
        private void PrintSum()
        {
            int val = 1;
            for (int i = 0; i < numRows; i++)
            {
                if (i % 2 == 0)
                {
                    PrintSpaces(numRows - i * 2 + 11);
                }
                else
                {
                    PrintSpaces(numRows - i * 2 + 11);
                }
                for (int j = 0; j <= i; j++)
                {
                    if (i == numRows - 1 && j == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if(i == numRows - 2 && (j == 2 || j == 3))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (i == 0 || j == 0)
                    {
                        val = 1;
                    }
                    else
                    {
                        val = val * (i - j + 1) / j;
                    }
                    if (val < 10)
                    {
                        Console.Write($"{val}   ");
                    }
                    else if (val < 100)
                    {
                        Console.Write($"{val}  ");
                    }
                    else
                    {
                        Console.Write($"{val} ");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        // Privatna metoda koja se koristi za specifičan prikaz trokuta u objašnjenju
        // Ispisuje se trokut sa 7 redova, brojevi u istoj dijagonali se prikazuju istom bojom
        private void PrintFibonacci()
        {
            int val = 1;
            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 0)
                {
                    PrintSpaces(7 - i * 2 + 11);
                }
                else
                {
                    PrintSpaces(7 - i * 2 + 11);
                }
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (i == 1 && j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if(i == 1 && j == 1 || i == 2 && j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if(i == 2 && j == 1 || i == 3 && j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if(i == 2 && j == 2 || i == 3 && j == 1 || i == 4 && j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if(i == 3 && j == 2 || i == 4 && j == 1 || i == 5 && j == 0)
                    {
                        Console.ForegroundColor= ConsoleColor.Gray;
                    }
                    else if(i == 3 && j == 3 || i == 4 && j == 2 || i == 5 && j == 1 || i == 6 && j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (i == 0 || j == 0)
                    {
                        val = 1;
                    }
                    else
                    {
                        val = val * (i - j + 1) / j;
                    }
                    if (val < 10)
                    {
                        Console.Write($"{val}   ");
                    }
                    else if (val < 100)
                    {
                        Console.Write($"{val}  ");
                    }
                    else
                    {
                        Console.Write($"{val} ");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        // Privatna metoda koja se koristi za specifičan prikaz trokuta u objašnjenju
        // Ispisuje se trokut sa 6 redova, svaki red se prikazuje zasebnom bojom
        private void PrintBinomialTheoremConnection()
        {
            int val = 1;
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    PrintSpaces(7 - i * 2 + 11);
                }
                else
                {
                    PrintSpaces(7 - i * 2 + 11);
                }
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (i == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (i == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (i == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (i == 0 || j == 0)
                    {
                        val = 1;
                    }
                    else
                    {
                        val = val * (i - j + 1) / j;
                    }
                    if (val < 10)
                    {
                        Console.Write($"{val}   ");
                    }
                    else if (val < 100)
                    {
                        Console.Write($"{val}  ");
                    }
                    else
                    {
                        Console.Write($"{val} ");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        // Privatna metoda za ispisivanje razmaka
        private void PrintSpaces(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write(" ");
            }
        }
    }
}

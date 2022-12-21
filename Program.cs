using PascalovTrokutBinomniPoucak;

Console.OutputEncoding = System.Text.Encoding.Unicode;
while (true)
{
    // Ovaj dio je zbog nekog cudnog buga koji se pojavi kad se vratis iz nekog moda.
    Console.Clear();
    Console.WriteLine("Clear");

    Console.Clear();
    Console.WriteLine(" [1] Pascalov Trokut");
    Console.WriteLine(" [2] Binomni Poučak");
    Console.WriteLine(" [Esc] Zatvori program");
    Console.WriteLine("\n Pritisnite odgovarajući znak za odabir");
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.D1)
    {
        Console.Clear();
        Console.Write("Broj redova: ");
        int brojRedova = 0;
        while (!int.TryParse(Console.ReadLine(), out brojRedova) || brojRedova > 13 || brojRedova < 1)
        {
            Console.Clear();
            Console.WriteLine("Broj redova mora biti u intervalu [1, 13]!\n");
            Console.Write("Broj redova: ");
        }
        while (true)
        {
            Console.Clear();
            PascalsTriangle pascalovTrokut = new PascalsTriangle(brojRedova);
            pascalovTrokut.Print();
            Console.WriteLine("\n[Esc] Povratak na Izbornik  [A] Dodaj Red  [R] Makni Red  [E] Objasni");
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.Escape)
            {
                break;
            }
            else if (key == ConsoleKey.A)
            {
                if (brojRedova != 13)
                {
                    brojRedova++;
                }
            }
            else if (key == ConsoleKey.R)
            {
                if (brojRedova != 1)
                {
                    brojRedova--;
                }
            }
            else if(key == ConsoleKey.E)
            {
                if(brojRedova < 4)
                {
                    Console.WriteLine("Minimalan broj redova za objašnjenje je 4. Probajte dodati još koji red.");
                    Thread.Sleep(3000);
                }
                else
                {
                    pascalovTrokut.Explain();
                }
            }
        }
    }
    else if (key == ConsoleKey.D2)
    {
        int n = 0;
        bool redo = true;
        while (true)
        {
            if (redo)
            {
                Console.Clear();
                Console.WriteLine("(x + y)ⁿ");
                Console.Write("Odaberi n: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.Clear();
                    Console.WriteLine("(x + y)ⁿ");
                    Console.Write("Odaberi n: ");
                }
                redo = false;
                BinomialTheorem binomialTheorem = new BinomialTheorem(n);
                Console.WriteLine(binomialTheorem.Calculate());
                Console.WriteLine("\n[Esc] Povratak na Izbornik  [R] Ponovi sa drugačijim n");
            }
            ConsoleKey consoleKey = Console.ReadKey().Key;
            if(consoleKey == ConsoleKey.R)
            {
                redo = true;
            }
            else if(consoleKey == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
    else if(key == ConsoleKey.Escape)
        return;
}
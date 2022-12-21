namespace PascalovTrokutBinomniPoucak
{
    public class PascalsTriangle
    {
        private int numRows;

        public PascalsTriangle(int numRows)
        {
            this.numRows = numRows;
        }

        public void Print()
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
                for(int j = 0; j <= i; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        val = 1;
                    }
                    else
                    {
                        val = val * (i - j + 1) / j;
                    }
                    if(val < 10)
                    {
                        Console.Write($"{val}   ");
                    }
                    else if(val < 100)
                    {
                        Console.Write($"{val}  ");
                    }
                    else
                    {
                        Console.Write($"{val} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void Explain()
        {
            while (true)
            {
                Console.Clear();
                Print();
                Console.WriteLine("\nPascalov trokut je trokutasti raspored brojeva koji daje koeficijente u proširenju bilo kojeg binomnog izraza, kao što je (x + y)ⁿ. Više o ovome na zadnjoj stranici.");
                Console.WriteLine("\n");
                Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.RightArrow)
                {
                    while (true)
                    {
                        Console.Clear();
                        PrintSum();
                        Console.WriteLine("\nTrokut se može konstruirati tako da se prvo postavi 1 duž lijevog i desnog ruba. Zatim se trokut može popuniti od vrha zbrajanjem dva broja lijevo i desno od svake pozicije u trokutu (kao što je prikazano u trokutu - zeleno = crveno + crveno).");
                        Console.WriteLine("\n");
                        Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");
                        consoleKey = Console.ReadKey().Key;
                        if (consoleKey == ConsoleKey.RightArrow)
                        {
                            while (true)
                            {
                                Console.Clear();
                                PrintFibonacci();
                                Console.WriteLine("\nTrokut prikazuje mnogo zanimljivih uzoraka. Na primjer, crtanje paralelnih \"plitkih dijagonala\" i zbrajanje brojeva u svakoj liniji zajedno proizvodi Fibonaccijev niz (1, 1, 2, 3, 5, 8, 13, 21... = S(zeleno), S(crveno) , S(žuta), S(magenta), S(cijan), S(siva), S(tamnoplava) gdje je S zbroj).");
                                Console.WriteLine("\n");
                                Console.WriteLine("[->] Sljedeća Stranica  [Esc] Završi Objašnjenje");
                                consoleKey = Console.ReadKey().Key;
                                if(consoleKey == ConsoleKey.RightArrow)
                                {
                                    Console.Clear();
                                    PrintBinomialTheoremConnection();
                                    Console.WriteLine("\nIz trokuta možemo vidjeti vezu s binomnim teoremom. Ako trokut podijelimo u retke, ono što dobivamo su koeficijenti binomnih izraza. Na primjer:");
                                    Console.WriteLine($"\t1. red [1]: (x + y){0.ToSuperscript()} = 1");
                                    Console.WriteLine($"\t2. red [1, 1]: (x + y){1.ToSuperscript()} = x + y");
                                    Console.WriteLine($"\t3. red [1, 2, 1]: (x + y){2.ToSuperscript()} = x{2.ToSuperscript()} + 2xy + y{2.ToSuperscript()}");
                                    Console.WriteLine($"\t4. red [1, 3, 3, 1]: (x + y){3.ToSuperscript()} = x{3.ToSuperscript()} + 3x{2.ToSuperscript()}y + 3xy{2.ToSuperscript()} + y{3.ToSuperscript()}");
                                    Console.WriteLine($"\t5. red [1, 4, 6, 4, 1]: (x + y){4.ToSuperscript()} = x{4.ToSuperscript()} + 4x{3.ToSuperscript()}y + 6x{2.ToSuperscript()}y{2.ToSuperscript()} + 4xy{3.ToSuperscript()} + y{4.ToSuperscript()}");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Pritisni bilo koju tipku za završetak objašnjenja.");
                                    Console.ReadKey();
                                    return;
                                }
                                else if (consoleKey == ConsoleKey.Escape)
                                    return;
                            }
                        }
                        else if (consoleKey == ConsoleKey.Escape)
                            return;
                    }
                }
                else if (consoleKey == ConsoleKey.Escape)
                    return;
            }
        }

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

        private void PrintSpaces(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.Write(" ");
            }
        }
    }
}

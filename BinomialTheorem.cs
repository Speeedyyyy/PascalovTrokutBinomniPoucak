using System.Numerics;

// Postavljamo klasu u zajednički namespace PascalovTrokutBinomniPoucak kako bi se mogla koristiti u programu
namespace PascalovTrokutBinomniPoucak
{
    public class BinomialTheorem
    {
        // Deklarira se privatni int za spremanje broja na koji se binom potencira
        private int n;

        // Konstruktor
        public BinomialTheorem(int n)
        {
            this.n = n;
        }

        // Metoda za izračunavanje formule binoma potenciranog na n
        public string Calculate()
        {
            // Deklarira se string koji će se slati za ispis u program
            string res = $"(x + y){n.ToSuperscript()} = x{n.ToSuperscript()}";
            for(int i = 1; i < n; i++)
            {
                res += $" + {BinomialCoefficient(n, i)}x{(n - i).ToSuperscript()}y{i.ToSuperscript()}";
            }
            res += $" + y{n.ToSuperscript()}";
            // Rjesenje se šalje u dio programa gdje je pozvano
            return res;
        }

        // Varijabla koja se koristi za izračun formule
        private BigInteger BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        // Izračunavanje faktorijele za izračun formule
        private BigInteger Factorial(int n)
        {
            BigInteger res = 1;
            for(int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}

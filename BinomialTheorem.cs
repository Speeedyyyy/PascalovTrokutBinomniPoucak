using System.Numerics;

namespace PascalovTrokutBinomniPoucak
{
    public class BinomialTheorem
    {
        private int n;

        public BinomialTheorem(int n)
        {
            this.n = n;
        }

        public string Calculate()
        {
            string res = $"(x + y){n.ToSuperscript()} = x{n.ToSuperscript()}";
            for(int i = 1; i < n; i++)
            {
                res += $" + {BinomialCoefficient(n, i)}x{(n - i).ToSuperscript()}y{i.ToSuperscript()}";
            }
            res += $" + y{n.ToSuperscript()}";
            return res;
        }

        private BigInteger BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

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

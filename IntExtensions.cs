// Postavljamo klasu u zajednički namespace PascalovTrokutBinomniPoucak kako bi se mogla koristiti u programu
namespace PascalovTrokutBinomniPoucak
{
    public static class IntExtensions
    {
        // Eksetenzija koja se u programu koristi za pretvaranje broja u odgovarajuću potenciju
        public static string ToSuperscript(this int number)
        {
            if (number == 1)
                return "";

            const string superscriptDigits = "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

            string superscript = "";
            superscript += new string(number.ToString().Select(x => superscriptDigits[x - '0']).ToArray());
            return superscript;
        }
    }
}

namespace Aufgabe.ZSK.Models
{
    public class Calculator
    {
        public static int ExchangeRateGoat { get; set; } = 500;
        public static int ExchangeRateLittleGoat { get; set; } = 50;
        public static int ExchangeRateSheep { get; set; } = 650;
        public static int ExchangeRateCow { get; set; }
        public int Goat { get; set; }
        public int LittleGoat { get; set; }
        public int Sheep { get; set; }
        public int Cow { get; set; }
        public int Euro { get; set; }
        public int RestEuro { get; set; }
        public bool EurToZsk { get; set; }

        public Calculator()
        {
            ExchangeRateCow = (3 * ExchangeRateGoat) + (2 * ExchangeRateSheep);
        }

        public void CalculateEUR()
        {
            Euro = (Cow * ExchangeRateCow)
                + (Sheep * ExchangeRateSheep)
                + (Goat * ExchangeRateGoat);
        }
        public void CalculateZSK()
        {
            RestEuro = Euro;

            Cow = RestEuro / ExchangeRateCow;
            RestEuro = RestEuro % ExchangeRateCow;

            Sheep = RestEuro / ExchangeRateSheep;
            RestEuro = RestEuro % ExchangeRateSheep;

            Goat = RestEuro / ExchangeRateGoat;
            RestEuro = RestEuro % ExchangeRateGoat;

            LittleGoat = RestEuro / ExchangeRateLittleGoat;
            RestEuro = RestEuro % ExchangeRateLittleGoat;
        }
    }
}

namespace Aufgabe.ZSK.Models
{
    public class Calculator
    {
        public static int ExchangeRateGoat = 500;
        public static int ExchangeRateLittleGoat = 50;
        public static int ExchangeRateSheep = 650;
        public static int ExchangeRateCow = (3 * ExchangeRateGoat) + (2 * ExchangeRateSheep);
        public int Goat { get; set; }
        public int LittleGoat { get; set; }
        public int Sheep { get; set; }
        public int Cow { get; set; }
        public int Euro { get; set; }
        public int RestEuro { get; set; }
        public bool EurToZsk { get; set; }

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

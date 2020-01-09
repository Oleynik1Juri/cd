namespace CurrencyConverter.Model
{
    public class Converter
    {
        public double Usd { get; }
        public double Eur { get; }
        public double Rub { get; }

        public Converter(double usd, double eur, double rub)
        {
            this.Usd = usd;
            this.Eur = eur;
            this.Rub = rub;
        }

        public double ConverterUA_v_USD(double uah)
        {
            double usd = uah / this.Usd;
            return usd;
        }

        public double ConverterUA_v_EUR(double uah)
        {
            double eur = uah / this.Eur;
            return eur;
        }

        public double ConverterUA_v_RUB(double uah)
        {
            double rub = uah * this.Rub;
            return rub;
        }
    }
}
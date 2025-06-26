namespace CurrencyConverter.Backend.Models
{
    public class ConversionResult
    {
        public string From { get; set; }
        public string To { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Result { get; set; }
    }
}

namespace CurrencyConverter.Backend.Models
{
    public class ConversionResult
    {
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Result { get; set; }
    }
}

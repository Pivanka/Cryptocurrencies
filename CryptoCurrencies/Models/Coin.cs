
namespace CryptoCurrencies.Models
{
    public class Coin
    {
        public Coin(string id, string rank, string name, string symbol, double priceUsd)
        {
            Id = id;
            Rank = rank;
            Name = name;
            Symbol = symbol;
            PriceUsd = priceUsd;
        }

        public string Id { get; set; }
        public string Rank { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double PriceUsd { get; set; }
    }
}

using System.Collections.ObjectModel;

namespace CryptoCurrencies.Models
{
    public class CoinList
    {
        public ObservableCollection<Coin> Data { get; set; }
    }
}

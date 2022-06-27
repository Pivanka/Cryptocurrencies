using CryptoCurrencies.Models;

namespace CryptoCurrencies.ViewModels
{
    public class CoinViewModel : ViewModelBase
    {
        private readonly Coin _coin;

        public string Rank => _coin.Rank;
        public string Name => _coin.Name;
        public string Symbol => _coin.Symbol;
        public double PriceUsd => _coin.PriceUsd;

        public CoinViewModel(Coin coin)
        {
            _coin = coin;
        }
    }
}

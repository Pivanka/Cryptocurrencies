using CryptoCurrencies.Infrastructure.Commands;
using CryptoCurrencies.Models;
using System;
using System.Windows.Input;

namespace CryptoCurrencies.ViewModels
{
    public class CoinViewModel : ViewModelBase
    {
        private readonly Coin _coin;

        public string Rank => _coin.Rank;
        public string Name => _coin.Name;
        public string Symbol => _coin.Symbol;
        public double PriceUsd => _coin.PriceUsd;

        public CoinViewModel(Coin coin, Stores.NavigationStore navigationStore, Func<DetailsViewModel> createCoinsViewModel)
        {
            _coin = coin;
            ShowDetailsCoinCommand = new NavigateCommand(navigationStore, createCoinsViewModel);
            
            //ShowCoinDetailsCommand(coin);

        }

        #region Commands
        //public ICommand FindCoinCommand { get; }
        public ICommand ShowDetailsCoinCommand { get; }

        #endregion
    }
}

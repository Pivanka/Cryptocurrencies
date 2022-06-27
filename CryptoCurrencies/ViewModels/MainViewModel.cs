using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencies.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CoinViewModel> _coins;
        public IEnumerable<CoinViewModel> Coins => _coins;
        public ICommand FindCoinCommand { get; }

        public MainViewModel()
        {
            _coins = new ObservableCollection<CoinViewModel>();
            _coins.Add(new CoinViewModel(new Models.Coin("BTC", "1", "Bitcoin", "BTC", 21000)));
        }
    }
}

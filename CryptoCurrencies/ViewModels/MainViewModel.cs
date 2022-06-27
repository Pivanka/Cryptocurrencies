using CryptoCurrencies.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencies.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CoinViewModel> _coins;
        public IEnumerable<CoinViewModel> Coins => _coins;
        public CoinList CoinResult { get; set; }
        public ICommand FindCoinCommand { get; }

        public MainViewModel()
        {
            _coins = new ObservableCollection<CoinViewModel>();
            //_coins.Add(new CoinViewModel(new Models.Coin("BTC", "1", "Bitcoin", "BTC", 21000)));
            ApiHelper.InitializeClient();
            LoadCoins();
        }

        #region Load Data
        public async void LoadCoins()
        {
            string url = "https://api.coincap.io/v2/assets";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CoinResult = await response.Content.ReadAsAsync<CoinList>();
                    for (int i = 0; i < 10; i++)
                    {
                        _coins.Add(new CoinViewModel(CoinResult.Data[i]));
                    }
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        #endregion
    }
}

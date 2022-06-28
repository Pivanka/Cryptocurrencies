using CryptoCurrencies.Infrastructure.Commands;
using CryptoCurrencies.Models;
using CryptoCurrencies.Stores;
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
    public class CoinsViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CoinViewModel> _coins;
        public IEnumerable<CoinViewModel> Coins => _coins;

        public CoinList CoinResult { get; set; }
        //public Coin SelectedCoin { get; set; }

        public NavigationStore _navigationStore;
        public Func<DetailsViewModel> CreateViewModel { get; }

        public CoinsViewModel(NavigationStore navigationStore, Func<DetailsViewModel> createDetailsViewModel)
        {
            _coins = new ObservableCollection<CoinViewModel>();
            ApiHelper.InitializeClient();
            _navigationStore = navigationStore;
            CreateViewModel = createDetailsViewModel;
            
            LoadCoins();
            ShowDetailsCoinCommand = new NavigateCommand(navigationStore, createDetailsViewModel);
        }

        #region Commands
        public ICommand FindCoinCommand { get; }
        public ICommand ShowDetailsCoinCommand { get; }
        #endregion

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
                        _coins.Add(new CoinViewModel(CoinResult.Data[i], _navigationStore, CreateViewModel));
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

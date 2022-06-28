using CryptoCurrencies.Models;
using CryptoCurrencies.Stores;
using CryptoCurrencies.ViewModels;
using CryptoCurrencies.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CryptoCurrencies
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Coin _coin;
        private readonly NavigationStore _navigatinStore;
        
        public App()
        {
            _navigatinStore = new NavigationStore();    
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigatinStore.CurrentViewModel = CreateCoinViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigatinStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private DetailsViewModel CreateDetailsViewModel()
        {
            return new DetailsViewModel(_navigatinStore, CreateCoinViewModel);
        }

        private CoinsViewModel CreateCoinViewModel()
        {
            return new CoinsViewModel(_navigatinStore, CreateDetailsViewModel);
        }
    }
}

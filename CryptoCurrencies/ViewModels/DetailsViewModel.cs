using CryptoCurrencies.Models;
using CryptoCurrencies.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {
        public DetailsViewModel(NavigationStore navigationStore, Func<CoinsViewModel> createCoinsViewModel)
        {
        }
    }
}

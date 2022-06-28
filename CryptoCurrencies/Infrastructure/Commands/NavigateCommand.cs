using CryptoCurrencies.Infrastructure.Commands.Base;
using CryptoCurrencies.Stores;
using CryptoCurrencies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Infrastructure.Commands
{
    public class NavigateCommand : Command
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parametr)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}

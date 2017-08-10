using System;
using System.Windows.Input;

using Foyeur.Models;
using Foyeur.Services;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using Windows.UI.Xaml;

namespace Foyeur.ViewModels
{
    public class CardsDetailDetailViewModel : ViewModelBase
    {

        public NavigationServiceEx NavigationService
        {
            get
            {
                return Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<NavigationServiceEx>();
            }
        }
        const string NarrowStateName = "NarrowState";
        const string WideStateName = "WideState";

        public ICommand StateChangedCommand { get; private set; }

        private Order _item;
        public Order Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public CardsDetailDetailViewModel()
        {
            StateChangedCommand = new RelayCommand<VisualStateChangedEventArgs>(OnStateChanged);
        }
        
        private void OnStateChanged(VisualStateChangedEventArgs args)
        {
            if (args.OldState.Name == NarrowStateName && args.NewState.Name == WideStateName)
            {
                NavigationService.GoBack();
            }
        }
    }
}

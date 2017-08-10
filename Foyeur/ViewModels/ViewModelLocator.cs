using Foyeur.Services;
using Foyeur.Views;

using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

namespace Foyeur.ViewModels
{
    public class ViewModelLocator
    {
        NavigationServiceEx _navigationService = new NavigationServiceEx();

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => _navigationService);
            Register<PivotViewModel, PivotPage>();
            Register<MainViewModel, MainPage>();
            Register<CardsDetailViewModel, CardsDetailPage>();
            Register<CardsDetailDetailViewModel, CardsDetailDetailPage>();
            Register<LocationsViewModel, LocationsPage>();
            Register<TrailersViewModel, TrailersPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public TrailersViewModel TrailersViewModel => ServiceLocator.Current.GetInstance<TrailersViewModel>();

        public LocationsViewModel LocationsViewModel => ServiceLocator.Current.GetInstance<LocationsViewModel>();

        public CardsDetailDetailViewModel CardsDetailDetailViewModel => ServiceLocator.Current.GetInstance<CardsDetailDetailViewModel>();

        public CardsDetailViewModel CardsDetailViewModel => ServiceLocator.Current.GetInstance<CardsDetailViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public void Register<VM, V>() where VM : class
        {
            SimpleIoc.Default.Register<VM>();
            
            _navigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}

using Foyeur.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Foyeur.Views
{
    public sealed partial class LocationsPage : Page
    {
        private LocationsViewModel ViewModel
        {
            get { return DataContext as LocationsViewModel; }
        }

        public LocationsPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}

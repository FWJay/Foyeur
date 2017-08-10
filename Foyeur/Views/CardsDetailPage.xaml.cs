using Foyeur.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Foyeur.Views
{
    public sealed partial class CardsDetailPage : Page
    {
        private CardsDetailViewModel ViewModel
        {
            get { return DataContext as CardsDetailViewModel; }
        }

        public CardsDetailPage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(WindowStates.CurrentState);
        }
    }
}

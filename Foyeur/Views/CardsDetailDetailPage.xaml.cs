using Foyeur.Models;
using Foyeur.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Foyeur.Views
{
    public sealed partial class CardsDetailDetailPage : Page
    {
        private CardsDetailDetailViewModel ViewModel
        {
            get { return DataContext as CardsDetailDetailViewModel; }
        }

        public CardsDetailDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as Order;
        }
    }
}

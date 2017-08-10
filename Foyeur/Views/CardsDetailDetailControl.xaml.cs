using Foyeur.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Foyeur.Views
{
    public sealed partial class CardsDetailDetailControl : UserControl
    {
        public Order MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Order; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(Order),typeof(CardsDetailDetailControl),new PropertyMetadata(null));

        public CardsDetailDetailControl()
        {
            InitializeComponent();
        }
    }
}

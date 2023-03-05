using DevExpress.Maui.CollectionView;
using DXMaui_App.ViewModels;

namespace DXMaui_App.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//LoginPage");
        }

        void OnCloseClicked(object sender, EventArgs e)
        {
            Current.FlyoutIsPresented = false;
        }
    }
}
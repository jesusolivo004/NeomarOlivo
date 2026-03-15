using Xamarin.Forms;
using MyApp.Pages;  // 👈 IMPORTANTE: para encontrar MainPage

namespace MyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
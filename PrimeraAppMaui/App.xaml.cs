using PrimeraAppMaui.Pages;

namespace PrimeraAppMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InicioPage());
        }
    }
}
   
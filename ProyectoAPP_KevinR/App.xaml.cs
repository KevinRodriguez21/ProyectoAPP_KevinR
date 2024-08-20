using ProyectoAPP_KevinR.Views;

namespace ProyectoAPP_KevinR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}

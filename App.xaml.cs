using OnlineDrive.Helper;
using Xamarin.Forms;

namespace OnlineDrive
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Settings.Email) && !string.IsNullOrEmpty(Settings.Password))
            {
                MainPage = new NavigationPage(new Views.DashBoard());
            }
            else
            {
                MainPage = new NavigationPage(new Views.login());
            }
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

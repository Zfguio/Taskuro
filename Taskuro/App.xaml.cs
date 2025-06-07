using Taskuro.Views.Public.LoginPage;

namespace Taskuro
{
    public partial class App : Application
    {
        Page LoginPageView = new Views.Public.LoginPage.LoginPageView();    
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(LoginPageView));
        }
    }
}
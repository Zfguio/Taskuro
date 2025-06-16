
namespace Taskuro
{
    public partial class App : Application
    {
        Page HomePageView;

        public App()
        {
            InitializeComponent();
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(new Taskuro.Resources.Styles.Dark());// well this needs to be here, otherwise the styles are not applied correctly
            // i will also treat dark mode as defult theme. unconventional, but i like it that way
            HomePageView = new Views.Private.HomePage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(HomePageView));
        }
    }
}
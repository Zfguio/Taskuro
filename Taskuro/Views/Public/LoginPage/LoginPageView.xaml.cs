namespace Taskuro.Views.Public.LoginPage;

public partial class LoginPageView : ContentPage
{
	public LoginPageView()
	{
		InitializeComponent();
		BindingContext = new ViewModels.Public.LoginPageViewModel();
    }
}
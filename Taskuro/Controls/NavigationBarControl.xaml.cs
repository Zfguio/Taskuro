namespace Taskuro.Controls.Private;

public partial class NavigationBarControl : ContentView
{
	public NavigationBarControl()
	{
		InitializeComponent();
		BindingContext = new ViewModels.NavigationBarControlView();
    }
}
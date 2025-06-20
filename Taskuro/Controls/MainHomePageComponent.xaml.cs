namespace Taskuro.Controls;

public partial class MainHomePageComponent : ContentView
{
	public MainHomePageComponent()
	{
		InitializeComponent();
		BindingContext = new ViewModels.MainTaskPageView();
    }
}
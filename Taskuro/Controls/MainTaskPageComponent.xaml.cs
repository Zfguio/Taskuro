namespace Taskuro.Controls;

public partial class MainTaskPageComponent : ContentView
{
	public MainTaskPageComponent()
	{
		InitializeComponent();
		BindingContext = new ViewModels.MainTaskPageView();
    }
}
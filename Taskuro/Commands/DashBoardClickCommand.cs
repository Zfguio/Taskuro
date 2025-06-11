using System.Windows.Input;

namespace Taskuro.Commands
{
    public class DashBoardClickCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;
        public async void Execute(object? parameter)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Taskuro.Views.Private.HomePage());
        }
    }
}

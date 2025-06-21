using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taskuro.Views;
using CommunityToolkit.Maui.Views;

namespace Taskuro.Commands
{
    class AddTaskClickCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true; // Always allow execution for this command
        }

        public void Execute(object? parameter)
        {
            var popup = new AddTaskPopUpPage();
            if (Application.Current.MainPage is not null && Application.Current.MainPage is Page page)
            {
                page.ShowPopup(popup);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("⚠️ Unable to show popup: MainPage is null or not a Page.");
            }
        }
    }
}

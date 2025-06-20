﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Taskuro.Commands
{
    public class TaskClickCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public async void Execute(object? parameter)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Taskuro.Views.TasksPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taskuro.Commands;

namespace Taskuro.ViewModels.Public
{
    public class LoginPageViewModel : BindableObject
    {
        public ICommand LoginCommand { get; }
        public LoginPageViewModel()
        {
            LoginCommand = new LoginCommand();
        }
    }
}

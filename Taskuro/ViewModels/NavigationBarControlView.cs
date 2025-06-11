using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Taskuro.ViewModels
{
    class NavigationBarControlView: BindableObject
    {
        public ICommand DashBoardClickCommand { get; set; }
        public NavigationBarControlView()
        {
                DashBoardClickCommand = new Commands.DashBoardClickCommand();
        }
    }
}

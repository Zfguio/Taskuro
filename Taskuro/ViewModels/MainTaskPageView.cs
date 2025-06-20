using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskuro.Data;
using Taskuro.Models;

namespace Taskuro.ViewModels
{
    public class MainTaskPageView: BindableObject
    {
        private ObservableCollection<Tasks> _tasks = new ObservableCollection<Tasks>();
        public ObservableCollection<Tasks> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }
        public MainTaskPageView()
        {
            LoadTasks();
        }
        private async void LoadTasks()
        {
            var taskList = await Database.getTasksAsync();
            _tasks = new ObservableCollection<Tasks>(taskList);
        }
    }
}

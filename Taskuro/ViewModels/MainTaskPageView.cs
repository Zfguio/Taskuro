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
    public class MainTaskPageView : BindableObject
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

        public Command<Tasks> ShowTaskOptionsCommand { get; }

        public MainTaskPageView()
        {
            LoadTasks();
            ShowTaskOptionsCommand = new Command<Tasks>(OnShowTaskOptions);
        }

        private async void LoadTasks()
        {
            var taskList = await Database.getTasksAsync();
            Tasks = new ObservableCollection<Tasks>(taskList);
        }

        private async void OnShowTaskOptions(Tasks task)
        {
            string action = await Application.Current.MainPage.DisplayActionSheet(
                $"Options for: {task.Title}",
                "Cancel",
                null,
                "Edit", "Delete");

            switch (action)
            {
                case "Edit":
                    // TODO: Navigate to edit screen
                    break;
                case "Delete":
                    await Database.deleteTask(task);
                    Tasks.Remove(task);
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SwipeControlTest.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<SampleModel> list { get; set; } = new ObservableCollection<SampleModel>();
        public ICommand MyCommand { get; set; }

        private Action<object> action = (paramet) =>
         {
             Debug.WriteLine(paramet.GetType());
         };

        public ViewModel()
        {
            list.Add(new SampleModel() { Text = "Hello1" });
            list.Add(new SampleModel() { Text = "Hello2" });
            list.Add(new SampleModel() { Text = "Hello3" });
            list.Add(new SampleModel() { Text = "Hello4" });
            list.Add(new SampleModel() { Text = "Hello5" });
            list.Add(new SampleModel() { Text = "Hello6" });
            list.Add(new SampleModel() { Text = "Hello7" });
            list.Add(new SampleModel() { Text = "Hello8" });
            list.Add(new SampleModel() { Text = "Hello9" });
            list.Add(new SampleModel() { Text = "Hello10" });
            MyCommand = new SampleCommand(action, true);
        }
    }

    public class SampleModel
    {
        public string Text { get; set; }

        public ICommand IncreaseItemCommand { get; set; }
    }

    public class SampleCommand : ICommand
    {
        public SampleCommand(Action<object> action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        private Action<object> _action;
        private bool _canExecute;

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }
    }
}
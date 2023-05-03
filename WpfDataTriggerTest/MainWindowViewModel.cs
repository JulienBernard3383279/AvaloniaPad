using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfDataTriggerTest
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _choice = 0;
        public int Choice
        {
            get => _choice;
            set
            {
                _choice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Choice)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            Change = new ChangeHandler(this);
        }

        public class ChangeHandler : ICommand
        {
            public ChangeHandler(MainWindowViewModel mwvm)
            {
                Mwvm = mwvm;
            }

            public MainWindowViewModel Mwvm { get; }

            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                Mwvm.DoChange();
            }
        }

        public ChangeHandler Change { get; }

        public void DoChange()
        {
            Choice = Choice == 0 ? 1 : 0;
        }
    }
}

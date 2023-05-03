using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfVVMSwitching2
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

        private object _subViewModel;
        public object SubViewModel
        {
            get => _subViewModel;
            set
            {
                _subViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SubViewModel)));
            }
        }

        private ViewModelA vma = new ViewModelA();
        private ViewModelB vmb = new ViewModelB();

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            _subViewModel = vma;
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
            if (Choice == 0)
            {
                Choice = -1;
                SubViewModel = vmb;
                Choice = 1;
            }
            else
            {
                Choice = -1;
                SubViewModel = vma;
                Choice = 0;
            }
        }
    }

    public class ViewModelA : INotifyPropertyChanged
    {
        public string PropertyA => "Property A";

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public class ViewModelB : INotifyPropertyChanged
    {
        public string PropertyB => "Property B";

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

using CommunityToolkit.Mvvm.ComponentModel;

namespace VVMSwitching.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int _choice = 0;

        [ObservableProperty]
        private object _subViewModel;

        private ViewModelA vma = new ViewModelA();
        private ViewModelB vmb = new ViewModelB();

        public MainWindowViewModel()
        {
            _subViewModel = vma;
        }

        public void Change()
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
            /*if (Choice == 0)
            {
                _subViewModel = vmb;
                Choice = 1;
                OnPropertyChanged(nameof(SubViewModel));
            }
            else
            {
                _subViewModel = vma;
                Choice = 0;
                OnPropertyChanged(nameof(SubViewModel));
            }*/
        }
    }

    public class ViewModelA : ViewModelBase
    {
        public string PropertyA => "Property A";
    }

    public class ViewModelB : ViewModelBase
    {
        public string PropertyB => "Property B";
    }


}
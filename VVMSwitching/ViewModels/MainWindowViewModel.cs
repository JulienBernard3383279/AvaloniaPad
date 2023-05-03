using CommunityToolkit.Mvvm.ComponentModel;

namespace VVMSwitching.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private object? _subViewModel;

        private ViewModelA vma = new ViewModelA();
        private ViewModelB vmb = new ViewModelB();

        public MainWindowViewModel()
        {
            _subViewModel = vma;
        }

        public void Change()
        {
            if (SubViewModel == vma)
            {
                SubViewModel = vmb;
            }
            else
            {
                SubViewModel = vma;
            }
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
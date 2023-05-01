using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AvaloniaPad.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<LineViewModel> Lines { get; set; }

        public MainWindowViewModel() {
            _lineViewModel = new LineViewModel();
            Lines = new ObservableCollection<LineViewModel>() {_lineViewModel };
        }

        private LineViewModel _lineViewModel;
    }

    public partial class LineViewModel : ViewModelBase {

        public LineViewModel()
        {
            Option = new ObservableCollection<string>() { "Foo", "Bar" };
        }

        [ObservableProperty]
        private int _index;

        public ObservableCollection<string> Option { get; set; }
    }
}
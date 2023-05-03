using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VVMSwitching.Views;

public partial class ViewB : UserControl
{
    public ViewB()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
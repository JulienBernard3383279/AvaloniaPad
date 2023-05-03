using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VVMSwitching.Views;

public partial class ViewA : UserControl
{
    public ViewA()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
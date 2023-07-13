using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace XIVToolkit.Views.Pages;

public partial class Checklist : Window
{
    public Checklist()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace XIVToolkit.Views.Pages;

public partial class Settings : Window
{
    public Settings()
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
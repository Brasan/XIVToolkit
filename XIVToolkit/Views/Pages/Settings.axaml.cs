using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using XIVToolkit.ViewModels;

namespace XIVToolkit.Views.Pages;

public partial class Settings : UserControl
{
    public Settings()
    {
        InitializeComponent();
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        var vm = new SettingsViewModel();
        DataContext = vm;
    }
}
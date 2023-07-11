using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using XIVToolkit.ViewModels;

namespace XIVToolkit.Views.Pages;

public partial class PriceCheck : UserControl
{
    public PriceCheck()
    {
        InitializeComponent();
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        var vm = new PriceCheckViewModel();
        DataContext = vm;
    }
}
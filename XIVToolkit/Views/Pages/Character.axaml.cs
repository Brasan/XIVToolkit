﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using XIVToolkit.ViewModels;

namespace XIVToolkit.Views.Pages;

public partial class Character : UserControl
{
    public Character()
    {
        InitializeComponent();
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        CharacterViewModel? vm = new CharacterViewModel();
        DataContext = vm;
    }
}
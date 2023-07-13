using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Xml;
using CommunityToolkit.Mvvm.ComponentModel;

namespace XIVToolkit.ViewModels;

public class ChecklistViewModel : ObservableObject
{
    public readonly DateTime now = DateTime.Now;
    public readonly List<string> DailyTasks = new() { "Grand company turn-ins", "Squadron mission", "Island Sanctuary"};
    public readonly List<string> WeeklyTasks = new() { "Cap tomestones", "BLU weeklies", "Wondrous Tails", "Unreal", "Custom Deliveries"};
    public readonly List<string> OtherTasks = new() { "Test", "Test2"};
}
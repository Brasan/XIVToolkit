using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Xml;
using CommunityToolkit.Mvvm.ComponentModel;
using XIVToolkit.Models;

namespace XIVToolkit.ViewModels;

public class ChecklistViewModel : ObservableObject
{
    public readonly DateTime now = DateTime.Now;
    public readonly List<string> DailyTasks = new() { "Grand company turn-ins", "Squadron mission", "Island Sanctuary"};
    public readonly List<string> WeeklyTasks = new() { "Cap tomestones", "BLU weeklies", "Wondrous Tails", "Unreal", "Custom Deliveries"};
    public readonly List<string> LongTasks = new() { "Test", "Test2"};
    private readonly List<ChecklistTask> _testTasks = new() { new(){Name="test task 1", Completed = true}, new(){Name="test task 2", Completed = false}};
    public ObservableCollection<ChecklistTask> TestTasks { get; set; }
    
    public ObservableCollection<Person> People { get; }

    public ChecklistViewModel()
    {
        var people = new List<Person> 
        {
            new Person("Neil", "Armstrong", false),
            new Person("Buzz", "Lightyear", true),
            new Person("James", "Kirk", true)
        };
        People = new ObservableCollection<Person>(people);
    }
}
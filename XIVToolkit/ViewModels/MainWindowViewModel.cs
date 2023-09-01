using System.Collections.Generic;
using System.Collections.ObjectModel;
using XIVToolkit.Models;
using XIVToolkit.Views;

namespace XIVToolkit.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string CharacterName => "Character Name";
    public string CharacterServer => "Server";
    public string ServerTime => "";
    public ObservableCollection<Person> People { get; }
    public MainWindowViewModel()
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

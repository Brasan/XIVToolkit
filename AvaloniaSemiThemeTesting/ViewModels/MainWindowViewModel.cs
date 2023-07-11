using AvaloniaSemiThemeTesting.Views;

namespace AvaloniaSemiThemeTesting.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public string CurrentPage => "Home";
    public string CharacterName => "Character Name";
    public string CharacterServer => "Server";

}

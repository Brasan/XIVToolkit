using System;
using System.Diagnostics;
using System.Text.Json.Nodes;
using System.Threading;
using System.Windows.Input;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using XIVToolkit.Models.API;

namespace XIVToolkit.ViewModels;

public partial class CharacterViewModel : ObservableObject
{
    [ObservableProperty]
    private string _characterImportStatusText = "Ready";
    [ObservableProperty]
    private Color _characterImportStatusColor = Colors.Green;
    [ObservableProperty]
    private string _characterImportId = "";

    public ICommand ImportCharacterCommand { get; }

    public CharacterViewModel()
    {
        ImportCharacterCommand = new RelayCommand(ImportCharacter);
    }

    private void ImportCharacter()
    {
        CharacterImportStatusText = "Importing";
        CharacterImportStatusColor = Colors.Orange;
        Thread.Sleep(2000);
        if (string.IsNullOrEmpty(CharacterImportId))
        {
            CharacterImportStatusText = "Ready";
            CharacterImportStatusColor = Colors.Green;
            return;
        }

        JsonObject importedCharacter = XIVAPI.ImportCharacter(CharacterImportId);

        CharacterImportStatusText = "Ready";
        CharacterImportStatusColor = Colors.Green;
        Debug.WriteLine("Imported character");
    }
}
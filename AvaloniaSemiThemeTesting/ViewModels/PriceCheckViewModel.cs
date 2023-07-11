using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using AvaloniaSemiThemeTesting.Models;
using AvaloniaSemiThemeTesting.Models.API;
using CommunityToolkit.Mvvm.ComponentModel;



namespace AvaloniaSemiThemeTesting.ViewModels;

public class PriceCheckViewModel : ObservableObject
{

    public string? GarlandToolsCsvInput { get; set; }
    public List<ItemPriceData> itemPriceData { get; set; }
    
    private const string ITEM_IDS_FILE_PATH = "./Data/items.json";
    private List<string> _itemNames { get; set; }
    private Dictionary<string, string> _itemIds { get; set; }
    
    private async Task<Dictionary<string, string>> MapItemNamesToIds(List<string> items) 
    {
       Debug.WriteLine("Beginning search");
       
           Dictionary<string, string> result = new();
       
           using var jsonStream = new StreamReader(ITEM_IDS_FILE_PATH);
           var dict = await JsonSerializer.DeserializeAsync<Dictionary<string, JsonObject>>(jsonStream.BaseStream);
           
           if (dict is null)
           {
               return new Dictionary<string, string>();
           }
           
           foreach (var key in dict.Keys)
           {
               if (items.Contains(dict[key]["en"]!.ToString()))
               {
                   result.Add(dict[key]["en"]!.ToString(), key);
               }
           }
           
           Debug.WriteLine("Ending search");
           return result;
    }
    
    //Garlandtools list retrieved with "$('.block.active').data('view').craftSet.export()" in console after selecting a list
    private async Task<List<string>> ExtractItemNamesFromGarlandtoolsList(string csvString)
    {
        List<string> result = new();

        var csvStringArray = csvString.Split('\n');
        
        foreach (var splitCsvString in csvStringArray)
        {
            result.Add(splitCsvString.Split(',')[0]);
        }

        return result;
    }

    public async Task RetrieveItemPrices()
    {
        if (string.IsNullOrEmpty(GarlandToolsCsvInput)) return;
        
        _itemNames = await ExtractItemNamesFromGarlandtoolsList(GarlandToolsCsvInput);
        _itemIds = await MapItemNamesToIds(_itemNames);
        await UniversalisAPI.RetreiveItemPriceData(_itemIds.Values.ToArray());
    }
}
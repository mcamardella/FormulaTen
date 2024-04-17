using FormulaTen.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http.Json;

namespace FormulaTen;

public partial class GarePage : ContentPage
{
    private string _baseUrlGare = "https://ergast.com/api/f1/";

    private readonly HttpClient _httpClient;

    public int _valueEntry = 2001;

    public ObservableCollection<RaceModel> _Races { get; set; } = new();
    public GarePage()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        BindingContext = this;
        ValueEntry.Text = _valueEntry.ToString();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        onLoading(_valueEntry);
    }

    public async void onLoading(int year) {
        _Races.Clear();
        RootGareModel response = await _httpClient.GetFromJsonAsync<RootGareModel>($"{_baseUrlGare}{_valueEntry}.json");
        response?.MRData.RaceTable.Races.ForEach(item => _Races.Add(item));
    }

    private void MinusButton_Clicked(object sender, EventArgs args)
    {
        _valueEntry--;
        onLoading(_valueEntry);
        ValueEntry.Text = _valueEntry.ToString();
        
    }
    private void PlusButton_Clicked(object sender, EventArgs args)
    {
        _valueEntry++;
        onLoading(_valueEntry);
        ValueEntry.Text = _valueEntry.ToString();
        
    }
}
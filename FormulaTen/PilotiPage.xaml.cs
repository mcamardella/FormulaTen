using FormulaTen.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http.Json;

namespace FormulaTen;

public partial class PilotiPage : ContentPage
{
    private string _baseUrlGare = "https://ergast.com/api/f1/";

    private readonly HttpClient _httpClient;

    public int _valueEntry = 2001;

    public ObservableCollection<DriverModel> _Drivers { get; set; } = new();

    public PilotiPage()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
        BindingContext = this;

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        onLoading(_valueEntry);
    }

    public async void onLoading(int year)
    {
        _Drivers.Clear();
        RootPilotiModel response = await _httpClient.GetFromJsonAsync<RootPilotiModel>($"{ _baseUrlGare}{_valueEntry}/drivers.json");
        response?.MRData.DriverTable.Drivers.ForEach(item => _Drivers.Add(item));
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
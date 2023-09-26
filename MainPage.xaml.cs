using System.ComponentModel;

namespace MarketPlace;

public partial class MainPage : ContentPage
{
    public Collection<Item> Items { get; set; }
    public int count;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        Items = new Collection<Item>
        {
            new() { Id = 1, Title = "test1", Description = "checking", Price = 10, ImageUrl = "dotnet_bot.png"},
            new() { Id = 2, Title = "test2", Description = "checking", Price = 20, ImageUrl = "dotnet_bot.png"},
            new() { Id = 3, Title = "test3", Description = "checking", Price = 30, ImageUrl = "dotnet_bot.png"},
            new() { Id = 4, Title = "test4", Description = "checking", Price = 40, ImageUrl = "dotnet_bot.png"}
        };
    }

    private void OnBuyClicked(object sender, EventArgs e)
    {
        return;
    }
}
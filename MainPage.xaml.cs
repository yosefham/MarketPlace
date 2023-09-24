namespace MarketPlace;

public partial class MainPage : ContentPage
{
    public List<Items> Items;
    public int count;

    public MainPage()
    {
        InitializeComponent();
        Items = new List<Items>
        {
            new Items { Id = 1, Title = "test1", Description = "checking", Price = 10, ImageUrl = "dotnet_bot.png"},
            new Items { Id = 2, Title = "test2", Description = "checking", Price = 20, ImageUrl = "dotnet_bot.png"},
            new Items { Id = 3, Title = "test3", Description = "checking", Price = 30, ImageUrl = "dotnet_bot.png"},
            new Items { Id = 4, Title = "test4", Description = "checking", Price = 40, ImageUrl = "dotnet_bot.png"}
        };
    }

    private void OnBuyClicked(object sender, EventArgs e)
    {
        return;
    }
}
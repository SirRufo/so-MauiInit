namespace MyApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage( MainPageViewModel viewModel )
    {
        InitializeComponent();
        BindingContext = viewModel;
        Appearing += async ( s, e ) => await viewModel.InitializeAsync();
    }
}

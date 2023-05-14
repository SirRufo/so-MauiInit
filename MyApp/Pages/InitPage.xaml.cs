namespace MyApp.Pages;

public partial class InitPage : ContentPage
{
    public InitPage( InitPageViewModel viewModel )
    {
        InitializeComponent();
        BindingContext = viewModel;
        Appearing += async ( s, e ) =>
        {
            await viewModel.InitializeAsync();
            InitCompleted?.Invoke( this, EventArgs.Empty );
        };
    }

    public event EventHandler<EventArgs> InitCompleted;
}

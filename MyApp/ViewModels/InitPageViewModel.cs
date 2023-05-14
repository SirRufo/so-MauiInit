namespace MyApp.ViewModels;

public class InitPageViewModel : ViewModelBase
{
    [Reactive] public string InitSection { get; private set; }
    protected override async Task OnInitializeAsync( CancellationToken cancellationToken )
    {
        await base.OnInitializeAsync( cancellationToken );
        InitSection = "Warm up DataServices";
        await Task.Delay( 2000 );
        InitSection = "Expand Images";
        await Task.Delay( 4000 );
        InitSection = "Feed the pets";
        await Task.Delay( 3000 );
    }
}
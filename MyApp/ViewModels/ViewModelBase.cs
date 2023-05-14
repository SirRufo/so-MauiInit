namespace MyApp.ViewModels;

public abstract class ViewModelBase : ReactiveObject
{
    [Reactive] public bool IsInitializing { get; private set; }

    public async Task InitializeAsync( CancellationToken cancellationToken = default )
    {
        IsInitializing = true;
        try
        {
            await OnInitializeAsync( cancellationToken );
        }
        finally
        {
            IsInitializing = false;
        }
    }

    protected virtual Task OnInitializeAsync( CancellationToken cancellationToken )
        => Task.CompletedTask;
}

namespace MyApp;

public partial class App : Application
{
    public App( InitPage init, AppShell shell )
    {
        InitializeComponent();

        init.InitCompleted += ( s, e ) => MainPage = shell;
        MainPage = init;
    }
}


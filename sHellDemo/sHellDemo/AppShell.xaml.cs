namespace sHellDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("events/details", typeof(EventDetailsPage));
    }
}

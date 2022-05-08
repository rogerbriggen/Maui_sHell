namespace sHellDemo;

public partial class EventsPage
{
    public EventsPage()
    {
        InitializeComponent();

        BindingContext = new EventsViewModel();
    }
}


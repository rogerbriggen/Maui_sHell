namespace sHellDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        Application.Current.UserAppTheme = (e.Value ? AppTheme.Dark : AppTheme.Light);
    }

}


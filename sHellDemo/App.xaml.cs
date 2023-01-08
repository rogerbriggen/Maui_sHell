namespace sHellDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        Shell.Current.Navigating += Current_Navigating;
        Shell.Current.Navigated += Current_Navigated;
	}

    private void Current_Navigated(object sender, ShellNavigatedEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Navigated from {e.Previous?.Location} to {e.Current.Location}");
    }

    private void Current_Navigating(object sender, ShellNavigatingEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Navigating from {e.Current.Location} to {e.Target.Location}");
    }
}

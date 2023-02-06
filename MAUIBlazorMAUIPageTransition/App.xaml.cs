namespace MAUIBlazorMAUIPageTransition;

public partial class App : Application
{
    public static IServiceProvider Services;
	public App(IServiceProvider provider)
	{
        InitializeComponent();
        Services = provider;
        MainPage = new NavigationPage(new MainPage());
    }


}

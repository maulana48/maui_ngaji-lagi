using MyMauiApplication.View.Auth;
namespace MyMauiApplication;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LupaPwPage), typeof(LupaPwPage));
	}
}
